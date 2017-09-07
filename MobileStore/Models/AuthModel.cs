using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class AuthModel: IssueDateModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string token { get; set; }

    }
}