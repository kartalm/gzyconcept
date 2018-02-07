using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Like : BaseEntity
    {
        public int ArticleId { get; set; }

        public int SiteUserId { get; set; }

        public string SiteUserIp { get; set; }

    }
}
