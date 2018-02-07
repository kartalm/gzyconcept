using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class DomainUserMap : BaseEntityMap<DomainUser>
    {
        public DomainUserMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.NameAndSurname).IsRequired().HasMaxLength(100);
            Property(a => a.Email).IsRequired().HasMaxLength(50);
            Property(a => a.Password).IsRequired().HasMaxLength(50);
             
        }
    }
}
