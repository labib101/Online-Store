using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class Customer : IssueDateModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ContactNumber { get; set; }

        public string IsPremiumSeller { get; set; }

        public int OrganisationId { get; set; }

        public int NumberOfSales { get; set; }

        public string DateOfBirth { get; set; }

        public string Gender { get; set; }
    }
}