using GzyConcept.Core.Common;
using GzyConcept.Core.DAL;
using GzyConcept.Core.Services;
using GzyConcept.ServiceImplementations;
using NLog;
using System.Web.Mvc;

namespace GzyConcept.Base
{
    public abstract class BaseController : Controller
    {
        protected static Logger ControllerLogger { get; set; }

        protected IDatabaseContext DatabaseContext { get; set; }
        
        protected ISessional SessionContext { get; set; }

        protected BaseController()
        {
            ControllerLogger = LogManager.GetCurrentClassLogger();

            var injectorService = DependencyInversionService.GetServiceInstance();

            DatabaseContext = injectorService.GetInstance<DatabaseContext>();

            SessionContext = injectorService.GetInstance<SiteSessionContext>();

        }
    }
}