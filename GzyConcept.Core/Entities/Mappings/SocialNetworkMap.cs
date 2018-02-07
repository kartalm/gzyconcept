using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class SocialNetworkMap : BaseEntityMap<SocialNetwork>
    {
        public SocialNetworkMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name).IsRequired().HasMaxLength(100);
            Property(a => a.Icon).IsRequired().HasMaxLength(100);
            Property(a => a.Link).IsRequired().HasMaxLength(150);
             
        }
    }
}
