using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GzyConcept.Core.Base
{
    [Serializable]
    public class BaseEntity : ICloneable
    {
        protected BaseEntity()
        {
            ExtendedProperties = new Dictionary<string, object>();
        }

        public int Id { get; set; }

        [NotMapped]
        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        [NotMapped]
        public IDictionary<string, object> ExtendedProperties { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}