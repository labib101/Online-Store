using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class LoginAuthentications
    {
        public int Id { get; set; }

        [Key]
        public string Email { get; set; }

        public string Password { get; set; }

        public string AuthToken { get; set; }

        public string Status { get; set; }

        public string LastUpdate { get; set; }

    }
}