using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class SloganMap : BaseEntityMap<Slogan>
    {
        public SloganMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Content).IsRequired().HasMaxLength(250); 
             
        }
    }
}