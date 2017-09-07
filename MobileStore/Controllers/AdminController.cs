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
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpPost]
        [ActionName("makeUserActive")]
        public IHttpActionResult makeUserActive(string Email)
        {
            LoginAuthentications user = unitOfWork.LoginAuthenticationRepository.GetByID(Email);

            user.Status = "Active";
            unitOfWork.LoginAuthenticationRepository.Update(user);
            unitOfWork.Save();

            return Ok(user);
        }

        [HttpPost]
        [ActionName("makeUserInactive")]
        public IHttpActionResult makeUserInactive(string Email)
        {
            LoginAuthentications user = unitOfWork.LoginAuthenticationRepository.GetByID(Email);

            user.Status = "Inactive";
            unitOfWork.LoginAuthenticationRepository.Update(user);
            unitOfWork.Save();

            return Ok(user);
        }

        [ActionName("getNumberOfAdmins")]
        public IHttpActionResult getNumberOfAdmins()
        {
            IEnumerable<LoginAuthentications> user = unitOfWork.LoginAuthenticationRepository.Get(u => u.AuthToken!= "Customer");
            return Ok(user);
        }

    }
}
