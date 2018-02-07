using GzyConcept.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.Common
{
    public class ClientMessage
    {
        public string Key { get; set; }

        public MessageType Type { get; set; }

        public string ExceptionId { get; set; }

    }
}
