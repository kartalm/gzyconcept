using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; } 

        public virtual List<Product> ProductCollection { get; set; }

    }
}
