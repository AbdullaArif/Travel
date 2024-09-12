using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CommentController : Controller
    {

        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            var values = commentManager.TGetListCommentWithDestination();
            return View(values);
        }
    }
}
