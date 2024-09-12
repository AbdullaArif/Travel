using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.AdminDashboard
{
    public class _GuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
