using GzyConcept.Core.ServiceAbstractions;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.Common
{
    public class DependencyInversionService : IDependencyResolution
    {
        public readonly Container Container;
        private static volatile DependencyInversionService _service;

        private static object _lock = new object();

        private DependencyInversionService()
        {
            if (Container == null)
            {
                Container = new Container();
            }
        }

        public static DependencyInversionService GetServiceInstance()
        {
            if (_service == null)
            {
                lock (_lock)
                {
                    _service = new DependencyInversionService();
                }
            }

            return _service;
        }

        public T GetInstance<T>() where T : class
        {
            return Container.GetInstance<T>();
        }

    }
}
