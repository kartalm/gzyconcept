using GzyConcept.Areas.ControlPanel.Base;
using System.Web.Mvc;

namespace GzyConcept.Areas.ControPanel.Controllers
{
    public class LoginController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}