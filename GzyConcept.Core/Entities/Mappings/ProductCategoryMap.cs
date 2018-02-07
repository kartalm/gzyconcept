using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class ProductCategoryMap : BaseEntityMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name).IsRequired().HasMaxLength(100); 

        }
    }
}