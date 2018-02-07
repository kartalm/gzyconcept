using GzyConcept.Core.Common;
using GzyConcept.Core.DAL;
using GzyConcept.Core.Entities;
using GzyConcept.Core.Extensions;
using GzyConcept.Core.Services;
using NLog;
using System;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GzyConcept.ServiceImplementations
{
    public class SiteSessionContext : ISessional
    {
        #region Declarations

        private string _clientIp;
        private DomainUser _domainUser;
        private Session _domainUserSession;
        private readonly IDatabaseContext _databaseContext;
        private readonly Logger _logger;

        #endregion

        public SiteSessionContext()
        {
            var injectorService = DependencyInversionService.GetServiceInstance();

            _databaseContext = injectorService.GetInstance<DatabaseContext>();
            _logger = LogManager.GetLogger("SessionServiceLogger");
        }

        public DomainUser DomainUser
        {
            get
            {
                if (HttpContext.Current.Session["Session"].IsNotNull() && _domainUser.IsNull())
                {
                    _domainUser = (DomainUser)HttpContext.Current.Session["Session"] as DomainUser;
                }

                return _domainUser;

            }
            set
            {
                _domainUser = value;

                var domainUserSession = _databaseContext.Set<Session>().FirstOrDefault(x => x.DomainUserId == _domainUser.Id);
                  
                #region Session 

                if (domainUserSession.IsNull())
                {
                    domainUserSession = new Session
                    {
                        LoginTime = DateTime.Now,
                        LogoutTime = null,
                        SessionId = HttpContext.Current.Session.SessionID
                    };

                    domainUserSession.DomainUserId = _domainUser.Id;
                    _databaseContext.Set<Session>().Add(domainUserSession);

                    try
                    {
                        _databaseContext.SaveChanges();
                        _domainUserSession = domainUserSession;
                    }
                    catch (Exception ex)
                    {
                        Clear();
                        var exceptionId = Guid.NewGuid();
                        _logger.Error(exceptionId + " - " + "Session cannot be saved. " + ex);
                        throw new AppException(exceptionId + " - " + "Session cannot be saved. ", ex);
                    }
                }
                else
                {
                    _domainUserSession = domainUserSession;
                }

                #endregion

                HttpContext.Current.Session["Session"] = _domainUser;
                HttpContext.Current.Session.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings["SessionAndCachingTimeout"].Trim());

            }
        }

        public Session DomainUserSession
        {
            get
            {
                var domainUser = (DomainUser)HttpContext.Current.Session["Session"] as DomainUser;

                if (domainUser.IsNotNull())
                {
                    var domainUserInDatabase = _databaseContext.Set<DomainUser>().FirstOrDefault(x => x.Id == domainUser.Id);

                    if (domainUserInDatabase.IsNull())
                    {
                        try
                        {
                            var domainUserSessionInDatabase = _databaseContext.Set<Session>().FirstOrDefault(x => x.DomainUserId == domainUser.Id);

                            if (domainUserSessionInDatabase != null)
                            {
                                _databaseContext.Set<Session>().Remove(domainUserSessionInDatabase);
                            }

                            return null;
                        }
                        catch (Exception ex)
                        {
                            var exceptionId = Guid.NewGuid();
                            _logger.Error(exceptionId + " - " + "Session cannot be deleted from database. " + ex);
                            Clear();
                        }
                    }
                    else
                    {
                        _domainUserSession.DomainUser = domainUser;
                    }
                }

                return _domainUserSession;
            }
            set
            {
                _domainUserSession = value;
            }
        }

        public string ClientIp
        {
            get
            {
                if (_clientIp.IsNotNullOrEmpty())
                {
                    return _clientIp;
                }

                _clientIp = HttpContext.Current.Request.ToClientIp();

                return _clientIp;

            }
        }

        public void Clear()
        {
            //logout time
            try
            {
                var currentDomainUserSession = _databaseContext.Set<Session>().FirstOrDefault(x => x.Id == DomainUserSession.Id);
                currentDomainUserSession.LogoutTime = DateTime.Now;

                _databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                var exceptionId = Guid.NewGuid();
                _logger.Error(exceptionId + " - " + "Session cannot be updated when clearing. " + ex.ToString());

                throw new AppException(exceptionId + " - " + "Session cannot be updated when clearing. ", ex);
            }

            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Session.RemoveAll();
            HttpContext.Current.Session["Session"] = null;
            HttpContext.Current.Session.Clear();

        }

    }
}