using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.AdminDashboard
{
    public class _TotalRevenue:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
          
            return View();
        }
    }
}
