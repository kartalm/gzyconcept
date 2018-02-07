using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class BlogCategoryMap : BaseEntityMap<BlogCategory>
    {
        public BlogCategoryMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Title).IsRequired().HasMaxLength(100);
             
        }
    }
}