using GzyConcept.Core.Base;
using System;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class AboutUs : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

    }
}