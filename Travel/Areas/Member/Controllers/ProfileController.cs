﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travel.Areas.Member.Models;

namespace Travel.Areas.Member.Controllers
{
	[Area("Member")]
	[Route("Member/[Controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel userEditViewModel = new UserEditViewModel();
			userEditViewModel.name = values.Name;
			userEditViewModel.surname = values.Surname;
			userEditViewModel.mail = values.Email;
			userEditViewModel.phonenumber = values.PhoneNumber;
			return View(userEditViewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel p)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (p.Image != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(p.Image.FileName);
				var imagename = Guid.NewGuid() + extension;
				var saveLocation = resource + "/wwwroot/usersImage/" + imagename;
				var stream = new FileStream(saveLocation,FileMode.Create);	
				await p.Image.CopyToAsync(stream);
				user.ImageUrl = imagename;

			}
			user.Name = p.name;
			user.Surname = p.surname;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
			var result = await _userManager.UpdateAsync(user);
			if (result.Succeeded) { return RedirectToAction("SignIn", "Login"); }
			return View();
		}
	}
}
