using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class AboutUsMap : BaseEntityMap<AboutUs>
    {
        public AboutUsMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(s => s.Title).IsRequired().HasMaxLength(100);
            Property(s => s.Content).IsRequired().HasMaxLength(8000);
            
        }
    }
}
