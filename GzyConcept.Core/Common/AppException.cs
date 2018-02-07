using NLog;
using System;
using System.Globalization;

namespace GzyConcept.Core.Common
{
    [Serializable]
    public class AppException : Exception
    {
        private readonly Logger _logger;

        public AppException()
        {
            //
        }

        public AppException(string message)
        : base(message)
        {
            _logger = LogManager.GetCurrentClassLogger();

            _logger.Error(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + " Error message : " + message);
        }

        public AppException(string message, Exception inner)
        : base(message, inner)
        {
            _logger = LogManager.GetCurrentClassLogger();

            _logger.Error(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + " Error message : " + message + " InnerException : " + inner.InnerException + " StackTrace : " + inner.StackTrace + " Message : " + inner.Message + " Data : " + inner.Data + " HResult : " + inner.HResult + " Source : " + inner.Source);
        }

    }
}
