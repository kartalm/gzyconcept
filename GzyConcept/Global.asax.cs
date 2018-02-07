using GzyConcept.Controllers;
using GzyConcept.Core.Common;
using GzyConcept.Helpers;
using NLog;
using SimpleInjector;
using System;
using System.Configuration;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using GzyConcept.Core.DAL;
using GzyConcept.Core.Services;
using GzyConcept.ServiceImplementations;
using GzyConcept.App_Start;
using System.Web.Optimization;

namespace GzyConcept
{
    public class Global : System.Web.HttpApplication
    {
        private Logger _logger;
         
        protected void Application_Start()
        {
            _logger = LogManager.GetLogger("ApplicationAndSessionLogger");
            _logger.Info("-----------------------------------------------------------------------------------------");
            _logger.Info("Application started.");

            //AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #region IoC (Simple Injector) Configuration

            var stopWatchLog = new StopWatchLogHelper();
            stopWatchLog.Start("WebApplication", " - IOC Configuration started.");

            try
            {
                var injectorService = DependencyInversionService.GetServiceInstance();

                injectorService.Container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

                injectorService.Container.Register<ISessional, SiteSessionContext>();
                injectorService.Container.Register<DatabaseContext>(Lifestyle.Scoped);
                
                //injectorService.Container.Register<ISessional, SiteSessionContext>(Lifestyle.Scoped);
                //injectorService.Container.Register<ISessional, SiteSessionContext>(Lifestyle.Scoped);

                injectorService.Container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

                injectorService.Container.RegisterMvcIntegratedFilterProvider();

                injectorService.Container.Verify();

                DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(injectorService.Container));
            }
            catch (Exception ex)
            {
                var exceptionId = Guid.NewGuid();

                _logger.Error(exceptionId + " - " + "Unable register container. " + ex.ToString());
                throw new AppException(exceptionId + " - " + "Unable register container. ", ex);
            }

            stopWatchLog.Stop(" - IOC Configuration finished. Elapsed time : ");

            #endregion
              
        }

        #region Session Methods

        protected void Session_Start(object sender, EventArgs args)
        {
            _logger = LogManager.GetLogger("ApplicationAndSessionLogger");

            var injectorService = DependencyInversionService.GetServiceInstance();

            var sessionContext = injectorService.GetInstance<SiteSessionContext>();

            try
            {
                _logger.Info("-----------------------------------------------------------------------------------------");
                _logger.Info("Session is created. Session Key " + sessionContext.DomainUserSession.SessionId == null ? "" : sessionContext.DomainUserSession.SessionId + " Ip : " + sessionContext.ClientIp == null ? "" : sessionContext.ClientIp + " Domain User Name : " + sessionContext.DomainUser.NameAndSurname);
            }
            catch (Exception ex)
            {
                _logger.Error("Session cannot be created!. Exception : " + ex);
            }
            
        }

        protected void Session_End(object sender, EventArgs args)
        {
            _logger = LogManager.GetLogger("ApplicationAndSessionLogger");

            var injectorService = DependencyInversionService.GetServiceInstance();

            var sessionContext = injectorService.GetInstance<SiteSessionContext>();

            try
            {
                _logger.Info("Session is terminated. Session Key : " + sessionContext.DomainUserSession.SessionId == null ? "" : sessionContext.DomainUserSession.SessionId + " Ip : " + sessionContext.ClientIp == null ? "" : sessionContext.ClientIp + " Domain User Name : " + sessionContext.DomainUser.NameAndSurname);
                _logger.Info("-----------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                _logger.Error("Session cannot be created!. Exception : " + ex);
            }
             
        }

        #endregion

        #region Application Methods

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var isApplicationErrorVisible = Boolean.Parse(ConfigurationManager.AppSettings["ApplicationErrorVisible"].Trim());

            Exception exception = Server.GetLastError();

            _logger = LogManager.GetLogger("ApplicationAndSessionLogger");

            _logger.Error(exception);

            if (!isApplicationErrorVisible)
            {
                Server.ClearError();

                RouteData routeData = new RouteData();
                routeData.Values.Add("controller", "Error");
                routeData.Values.Add("action", "Index");
                routeData.Values.Add("exception", exception);

                if (exception.GetType() == typeof(HttpException))
                {
                    routeData.Values.Add("statusCode", ((HttpException)exception).GetHttpCode());
                }
                else
                {
                    routeData.Values.Add("statusCode", 500);
                }

                IController controller = new ErrorController();
                controller.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
                Response.End();
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            _logger = LogManager.GetLogger("ApplicationAndSessionLogger");
            _logger.Info("Application stopped.");
            _logger.Info("-----------------------------------------------------------------------------------------");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //
        }

        #endregion

    }
}