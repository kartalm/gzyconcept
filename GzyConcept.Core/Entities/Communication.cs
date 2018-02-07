using GzyConcept.Core.Base;
using System;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Communication : BaseEntity
    {
        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string MapLink { get; set; }

        public string Email { get; set; }

    }
}