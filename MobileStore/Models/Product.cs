using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class Product : IssueDateModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int SubCategoryTypeId { get; set; }
    
        public int? IsPremium { get; set; }

        public string ProductPicture { get; set; }

        public string Status { get; set;}

        public int CustomerId { get; set; }

        public int Quantity { get; set; }

        public int ProductView { get; set; }
    }
}