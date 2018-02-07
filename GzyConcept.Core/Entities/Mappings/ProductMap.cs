using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class ProductMap : BaseEntityMap<Product>
    {
        public ProductMap()
        { 
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name).IsRequired().HasMaxLength(100);
            Property(a => a.Image).IsRequired().HasMaxLength(100);
            Property(a => a.Explanation).IsRequired().HasMaxLength(250); 
             
        }
    }
}