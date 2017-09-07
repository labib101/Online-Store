using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class DbSeeder : DropCreateDatabaseIfModelChanges<StoreDbContext>
    {
        protected override void Seed(StoreDbContext context)
        {
            LoginAuthentications Admin = new LoginAuthentications()
            {
                Email = "admin@gmail.com",
                Password = "123",
                AuthToken = "Admin",
                Status="Active"
            };
            context.Auths.Add(Admin);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}