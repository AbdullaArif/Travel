﻿using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.MemberDashboard
{
    public class _ProfileInformation:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.Name + " " + values.Surname;
            ViewBag.memberMail =values.Email;
            ViewBag.memberPhone =values.PhoneNumber;

            return View(values);
        }
    }
}
