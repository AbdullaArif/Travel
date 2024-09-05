using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.MemberDashboard
{
    public class _GuideListPartial:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
