using GzyConcept.Core.Extensions;

namespace GzyConcept.Core.Common
{
    public static class ConnectionString
    {
        #region Declarations

        private static string _hostName = string.Empty;

        private static string _sqlInstanceName = string.Empty;

        private static string _databaseName = string.Empty;

        private static string _sqlServerUserName = string.Empty;

        private static string _sqlServerUserPassword = string.Empty;

        private static string _sqlConnectionString = string.Empty;

        private static bool _integratedSecurity = false;

        #endregion

        public static string HostName
        {
            get
            {
                if (_hostName.IsNullOrEmpty())
                {
                    _hostName = System.Net.Dns.GetHostName();
                }

                return _hostName;
            }
            set
            {
                _hostName = value;
            }
        }

        public static string SqlInstanceName
        {
            get
            {
                if (_sqlInstanceName.IsNullOrEmpty())
                {
                    _sqlInstanceName = @"SQLEXPRESSDBMS";
                }

                return _sqlInstanceName;
            }
            set
            {
                _sqlInstanceName = value;
            }
        }

        public static string DatabaseName
        {
            get
            {
                if (_databaseName.IsNullOrEmpty())
                {
                    _databaseName = @"GzyConcept";
                }

                return _databaseName;
            }
            set
            {
                _databaseName = value;
            }
        }

        public static bool IntegratedSecurity
        {
            get
            {
                return _integratedSecurity;
            }
            set
            {
                _integratedSecurity = value;
            }
        }

        public static string SqlServerUserName
        {
            get
            {
                if (_sqlServerUserName.IsNullOrEmpty())
                {
                    _sqlServerUserName = @"sa";
                }

                return _sqlServerUserName;
            }
            set
            {
                _sqlServerUserName = value;
            }
        }

        public static string SqlServerUserPassword
        {
            get
            {
                if (_sqlServerUserPassword.IsNullOrEmpty())
                {
                    _sqlServerUserPassword = @"eae2014*";
                }

                return _sqlServerUserPassword;
            }
            set
            {
                _sqlServerUserPassword = value;
            }
        }

        public static string ToString()
        {
            var isUseConfigConnectionString = System.Configuration.ConfigurationManager.AppSettings["IsUseConfigConnectionString"].Trim();

            if (bool.Parse(isUseConfigConnectionString))//use config connection string
            {
                _sqlConnectionString = "DomainConnectionString";
            }
            else
            {
                _sqlConnectionString = @"Data Source=" + HostName + @"\" + SqlInstanceName + @";MultipleActiveResultSets=True;Initial Catalog=" + DatabaseName + (IntegratedSecurity ? ";Integrated Security=true;" : @";user id=" + SqlServerUserName + @";password=" + SqlServerUserPassword + @";");
            }
             
            return _sqlConnectionString;

        }

    }
}