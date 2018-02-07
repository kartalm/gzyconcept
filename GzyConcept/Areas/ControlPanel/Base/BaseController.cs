using GzyConcept.Core.Common;
using GzyConcept.Core.DAL;
using GzyConcept.Core.Services;
using NLog;
using System.Web.Mvc;

namespace GzyConcept.Areas.ControlPanel.Base
{
    public abstract class BaseController : Controller
    {
        protected static Logger ControlPanelControllerLogger { get; set; }

        protected IDatabaseContext DatabaseContext { get; set; }

        protected ISessional SessionContext { get; set; }

        public BaseController()
        {
            ControlPanelControllerLogger = LogManager.GetCurrentClassLogger();

            var injectorService = DependencyInversionService.GetServiceInstance();

            DatabaseContext = injectorService.GetInstance<DatabaseContext>();

            //SessionContext = injectorService.GetInstance<ControlPanelSessionContext>();
        }
         
    }
}