using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FeatureMainManager featureMainManager = new FeatureMainManager(new EfFeatureMainDal());
            var values = featureMainManager.TGetList();
            return View(values);
        }
    }
}
