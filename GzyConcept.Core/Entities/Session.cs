using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Session : BaseEntity
    {
        public DateTime LoginTime { get; set; }

        public DateTime? LogoutTime { get; set; }

        public string SessionId { get; set; }

        public int? DomainUserId { get; set; }

        public virtual DomainUser DomainUser { get; set; }

        public int? SiteUserId { get; set; }

        public virtual SiteUser SiteUser { get; set; }

    }
}
