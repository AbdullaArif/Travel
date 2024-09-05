using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.MemberDashboard
{
    public class _PlatformSettingPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
