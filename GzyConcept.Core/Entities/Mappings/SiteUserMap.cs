using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class SiteUserMap : BaseEntityMap<SiteUser>
    {
        public SiteUserMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.NameAndSurname).IsRequired().HasMaxLength(100);
            Property(a => a.UserName).IsRequired().HasMaxLength(100);
            Property(a => a.Password).IsRequired().HasMaxLength(50);
             
        }
    }
}