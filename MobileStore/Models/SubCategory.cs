using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class SubCategory : IssueDateModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string SubCategoryPicture { get; set; }

        public int SubCategoryView { get; set; }
    }
}