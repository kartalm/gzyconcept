using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class ArticleMap : BaseEntityMap<Article>
    {
        public ArticleMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Title).IsRequired().HasMaxLength(100);
            Property(a => a.Content).IsRequired().HasMaxLength(8000);
            Property(a => a.Image).IsRequired().HasMaxLength(200);
            Property(a => a.PublishedDate).IsRequired();
            
        }
    }
}
