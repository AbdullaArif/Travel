using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.AdminDashboard
{
    public class _DestinationStatistic:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
