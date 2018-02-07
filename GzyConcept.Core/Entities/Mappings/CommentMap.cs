using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class CommentMap : BaseEntityMap<Comment>
    {
        public CommentMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Title).IsRequired().HasMaxLength(100);
            Property(a => a.Content).IsRequired().HasMaxLength(250);
             
        }
    }
}