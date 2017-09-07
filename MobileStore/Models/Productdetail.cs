using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class Productdetail
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Description { get; set; }

        public string ProductDeliveryOptions { get; set; }
    }
}