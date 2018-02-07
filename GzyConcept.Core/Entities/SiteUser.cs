using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class SiteUser : BaseEntity
    {
        public string NameAndSurname { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public DateTime ActivatedDate { get; set; }

        public string Image { get; set; }

        public virtual List<Comment> CommentCollection { get; set; }

        public override string ToString()
        {
            return NameAndSurname;
        }

        public string ToUserNameString()
        {
            return UserName;
        }

    }
}