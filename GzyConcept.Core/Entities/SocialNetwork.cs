using GzyConcept.Core.Base;
using System;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class SocialNetwork : BaseEntity
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public string Icon { get; set; }

    }
}