using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class BlogCategory : BaseEntity
    {
        public string Title { get; set; }

        public string Explanation { get; set; }

        public virtual List<Article> ArticleCollection { get; set; }

    }
}