using GzyConcept.Core.Base;
using System;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Comment : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int? ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public bool IsPublished { get; set; }

        public int? SiteUserId { get; set; }

        public SiteUser SiteUser { get; set; }

    }
}