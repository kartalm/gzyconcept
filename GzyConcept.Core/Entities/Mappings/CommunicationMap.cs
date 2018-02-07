using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class CommunicationMap : BaseEntityMap<Communication>
    {
        public CommunicationMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Address).IsRequired().HasMaxLength(250);
            Property(a => a.Email).IsRequired().HasMaxLength(50);
             
        }
    }
}
