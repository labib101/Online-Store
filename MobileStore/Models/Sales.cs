using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class Sales : IssueDateModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public int Price { get; set; }
        
        public string DeliveryMethod { get; set; }

        public int Quantity { get; set; }
    }
}