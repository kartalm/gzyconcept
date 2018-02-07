using GzyConcept.Core.Base;
using System;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Slogan : BaseEntity
    {
        public string Content { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PublishedDate { get; set; }

    }
}
