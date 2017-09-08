using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.DAL
{
    public class ModelCreation
    {
        private AuthModel auth = new AuthModel();

        public AuthModel Create(Customer customer)
        {
            auth.Name = customer.FirstName + " " + customer.LastName;
            auth.Email = customer.Email;
            auth.token = "Customer";

            return auth;
        }

        public AuthModel Create(Organisation organisation)
        {
            auth.Name = organisation.Name;
            auth.Email = organisation.Email;
            auth.token = "Organisation";

            return auth;
        }

        public AuthModel Create(Admins admins)
        {
            auth.Name = admins.FirstName;
            auth.Email = admins.Email;
            auth.token = admins.AdminLevel;

            return auth;
        }

        public AuthModel Create(LoginAuthentications loginAuthentications)
        {
            
            auth.Email = loginAuthentications.Email;
            auth.token = loginAuthentications.AuthToken;

            return auth;
        }
    }
}