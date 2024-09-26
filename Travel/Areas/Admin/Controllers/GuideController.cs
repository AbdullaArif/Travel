using BuisnessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using BuisnessLayer.ValidationRules;

namespace Travel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {

        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
           var result =  validationRules.Validate(guide);
            if (result.IsValid)
            {
_guideService.TAdd(guide);
            return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToFalse(int id)
        {

            return RedirectToAction("Index");
        }
    }
}
