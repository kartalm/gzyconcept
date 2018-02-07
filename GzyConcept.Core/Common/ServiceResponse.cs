using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.Common
{
    public class ServiceResponse
    {
        public ClientMessage Message { get; set; }

        public bool IsSucceed
        {
            get
            {
                return Exception == null;
            }
        }

        public AppException Exception { get; set; }

    }

    public class ServiceResponse<T> : ServiceResponse
    {
        public T Data { get; set; }

        public bool HasData
        {
            get
            {
                return Data != null;
            }
        }
    }

}
