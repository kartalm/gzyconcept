using System.Data.Entity.ModelConfiguration;

namespace GzyConcept.Core.Base
{
    public class BaseEntityMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityMap()
        {
            Map(x => x.Requires("IsDeleted").HasValue(false)).Ignore(x => x.IsDeleted);
        }

    }
}
