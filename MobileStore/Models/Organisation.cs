using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class Organisation : IssueDateModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string ContactNumber { get; set; }

        public string CompanyWebsite { get; set; }

        public int IsPremium { get; set; }

    }
}