using GzyConcept.Core.Base;
using GzyConcept.Core.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GzyConcept.Core.Extensions
{
    public static class Database
    {
        public static IQueryable<T> IncludeRelations<T>(this IQueryable<T> source, params Expression<Func<T, object>>[] includes) where T : BaseEntity
        {
            if (includes != null)
            {
                foreach (var inc in includes)
                {
                    source = source.Include(inc);
                }
            }

            return source;

        }

        public static void RemoveAll<T>(this IDatabaseContext context, IEnumerable<T> source) where T : BaseEntity
        {

            if (source != null)
            {
                var list = source.ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    var s = list[i];

                    context.Entry(s).State = EntityState.Deleted;
                }
            }


        }

        public static void Remove<T>(this IDatabaseContext context, T source) where T : BaseEntity
        {
            if (source != null)
            {
                context.Entry(source).State = EntityState.Deleted;
            }
        }

    }
}
