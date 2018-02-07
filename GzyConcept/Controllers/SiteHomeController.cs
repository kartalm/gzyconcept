using GzyConcept.Base;
using System.Web.Mvc;

namespace GzyConcept.Controllers
{
    public class SiteHomeController : BaseController
    { 
        public ActionResult Index()
        {
            return View();
        }
    }
}