using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class IssueDateModel
    {
        public string IssueDate { get; set; }

        public IssueDateModel() { IssueDate = DateTime.Now.ToString(); }
    }
}