using GzyConcept.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Entities.Mappings
{
    public class MessageMap : BaseEntityMap<Message>
    {
        public MessageMap()
        {
            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Title).IsRequired().HasMaxLength(100); 
            Property(a => a.Content).IsRequired().HasMaxLength(250);
            Property(a => a.SentDate).IsRequired();
            Property(a => a.SenderInformation).IsRequired().HasMaxLength(100);
             
        }
    }
}
