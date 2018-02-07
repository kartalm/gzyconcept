using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GzyConcept.Helpers
{
    public class StopWatchLogHelper
    {
        private Stopwatch _stopWatch;
        private Logger _logger;

        public StopWatchLogHelper()
        {
            _logger = LogManager.GetLogger("StopWatchLogger");
        }

        public void Start(string loggerName, string message)
        {
            _stopWatch = new Stopwatch();
            _stopWatch.Start();

            _logger.Info(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + message);
        }

        public void Stop(string message)
        {
            _logger = LogManager.GetLogger("StopWatchLogger");

            _stopWatch.Stop();

            TimeSpan timeSpan = _stopWatch.Elapsed;

            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);

            _logger.Info(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture) + message + elapsedTime);
        }

    }
}