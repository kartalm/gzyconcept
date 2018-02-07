using GzyConcept.Core.Base;
using System;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class Message : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime SentDate { get; set; }

        public bool IsRead { get; set; }

        public string SenderInformation { get; set; }

    }
}