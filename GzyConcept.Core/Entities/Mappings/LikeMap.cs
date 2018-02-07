using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.Entities.Mappings
{
    public class LikeMap : BaseEntityMap<Like>
    {
        public LikeMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.ArticleId).IsRequired();
            Property(a => a.SiteUserId).IsRequired();
            Property(a => a.SiteUserIp).IsRequired().HasMaxLength(50);
            
        }
    }
}
