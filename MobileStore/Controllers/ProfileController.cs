using MobileStore.DAL;
using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileStore.Controllers
{
    [RoutePrefix("api/Profile")]
    public class ProfileController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpPost]
        [ActionName("insertCustomer")]
        public IHttpActionResult insertCustomer(Customer customer)
        {

            Customer c = unitOfWork.CustomerRepository.GetByID(customer.Id);
            if (c != null)
            {
                unitOfWork.CustomerRepository.Update(customer);
                unitOfWork.Save();
                return Ok(customer);
            }

            UserCredentials userCredentials = new UserCredentials();

            string conf = userCredentials.create(customer);
            unitOfWork.CustomerRepository.Insert(customer);
            unitOfWork.Save();

            return Ok(conf);
        }

        [HttpPost]
        [ActionName("insertOrganisation")]
        public IHttpActionResult insertOrganisation(Organisation organisation)
        {

            Organisation o = unitOfWork.OrganisationRepository.GetByID(organisation.Id);
            if (o != null)
            {
                unitOfWork.OrganisationRepository.Update(organisation);
                unitOfWork.Save();
                return Ok(organisation);
            }

            UserCredentials userCredentials = new UserCredentials();

            string conf = userCredentials.create(organisation);
            unitOfWork.OrganisationRepository.Insert(organisation);
            unitOfWork.Save();

            return Ok(conf);
        }

        [HttpPost]
        [ActionName("insertAdmin")]
        public IHttpActionResult insertAdmin(Admins admins)
        {

            Admins a = unitOfWork.AdminsRepository.GetByID(admins.Id);
            if (a != null)
            {
                unitOfWork.AdminsRepository.Update(admins);
                unitOfWork.Save();
                return Ok(admins);
            }

            UserCredentials userCredentials = new UserCredentials();

            string conf = userCredentials.create(admins);
            unitOfWork.AdminsRepository.Insert(admins);
            unitOfWork.Save();

            return Ok(conf);
        }
    }
}
