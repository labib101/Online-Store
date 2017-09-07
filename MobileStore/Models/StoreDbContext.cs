using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class StoreDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Productdetail> ProductDetails { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Organisation> Organisations { get; set; }

        public DbSet<LoginAuthentications> Auths { get; set; }

        public DbSet<Sales> Sales { get; set; }

        public DbSet<Admins> admins { get; set; }
    }
}