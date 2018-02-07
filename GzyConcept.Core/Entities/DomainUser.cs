using GzyConcept.Core.Base;
using System;
using System.Collections.Generic;

namespace GzyConcept.Core.Entities
{
    [Serializable]
    public class DomainUser : BaseEntity
    {
        public string NameAndSurname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Image { get; set; }

        public virtual List<Article> ArticleCollection { get; set; }

        public override string ToString()
        {
            return NameAndSurname;
        }

    }
}