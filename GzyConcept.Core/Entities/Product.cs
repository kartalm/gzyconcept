using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public string Explanation { get; set; }

        public bool IsSliderImage { get; set; }

        public List<string> LabelCollection { get; set; } 

        public int? ProductCategoryId { get; set; }

        public virtual ProductCategory Category { get; set; }

    }
}