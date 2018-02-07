using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Article : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public DateTime PublishedDate { get; set; }

        public bool IsPublished { get; set; }
        
        public List<string> LabelCollection { get; set; }

        public int? BlogCategoryId { get; set; }

        public virtual BlogCategory Category { get; set; }

        public int? DomainUserId { get; set; }

        public virtual DomainUser DomainUser { get; set; }

        public virtual List<Comment> CommentCollection { get; set; }

    }
}