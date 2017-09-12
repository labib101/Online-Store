using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MobileStore.DAL;

namespace MobileStore.Controllers
{
    
    [RoutePrefix("api/Authentication")]
    public class AuthenticationController : ApiController
    {
        private StoreDbContext ctx = new StoreDbContext();
        private UnitOfWork unitOfWork = new UnitOfWork();
        private UserCredentials userCredentials = new UserCredentials();

        [HttpPost]
        [ActionName("login")]
        public HttpResponseMessage login(LoginAuthentications auth)
        {
            string email = auth.Email.ToString();
            LoginAuthentications Usercheck = ctx.Auths.SingleOrDefault(d => d.Email == email);
            if (Usercheck != null)
            {
                if (Usercheck.Password == auth.Password)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Usercheck);
                    //response.Content(Usercheck.Auth.ToString());
                    string resp = Usercheck.AuthToken.ToString();
                    return response;
                }
                else
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Incorrect User Name or password");

                    return response;

                }
            }
            else
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Incorrect User Name or password");
                return response;
            }
        }

        [HttpPost]
        [ActionName("forgetPassward")]
        public IHttpActionResult forgetPassward(LoginAuthentications loginAuthentications)
        {
            LoginAuthentications check = unitOfWork.LoginAuthenticationRepository.GetByID(loginAuthentications.Email);
            if(check!= null)
            {

                userCredentials.forget(check);
                return Ok("Please Check Email for further Instructions");

            }
            else
            {
                return Ok("No Matching Account");
            }
        }

        [HttpPost]
        [ActionName("changePassword")]
        public IHttpActionResult changePassword(UpdatePasswordModel updatePasswordModel)
        {
            LoginAuthentications check = unitOfWork.LoginAuthenticationRepository.GetByID(updatePasswordModel.Email);
            if (check != null)
            {

                userCredentials.changePassword(check, updatePasswordModel);
                return Ok("Password Updated Successfully");

            }
            else
            {
                return Ok("Error Occured");
            }
        }

    }
}
