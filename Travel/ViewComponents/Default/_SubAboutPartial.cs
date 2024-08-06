using BuisnessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.Default
{
    public class _SubAboutPartial:ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager( new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
             var values = subAboutManager.TGetList();
             return View(values); 
        }
    
    }
}
