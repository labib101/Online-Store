using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class UpdatePasswordModel
    {
        public string Email { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}