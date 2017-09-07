using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore
{
    public class MailModel
    {
        public string MailTo { get; set; }

        public string MailSubject { get; set; }

        public string MailBody { get; set; }

        public MailModel() { }
    }
}