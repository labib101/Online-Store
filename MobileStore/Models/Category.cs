using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class Category: IssueDateModel
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string CategoryPicture { get; set; }

        public int SubCategoryView { get; set; }
    }
}