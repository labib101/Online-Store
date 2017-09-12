using MobileStore.MailService;
using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.DAL
{
    public class UserCredentials :RandomNumber
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private ModelCreation modelCreation = new ModelCreation();

        //Code to Create UserCredentials of the Organisation
        public string create(Admins admins)
        {

            AuthModel authModel = modelCreation.Create(admins);
            string confirmation = create(authModel);
            return confirmation;
        }

        //Code to Create UserCredentials of the Organisation
        public string create(Organisation organisation)
        {

            AuthModel authModel = modelCreation.Create(organisation);
            string confirmation = create(authModel);
            return confirmation;
        }

        //Code to Create UserCredentials of the Customer
        public string create(Customer customer) {

            AuthModel authModel = modelCreation.Create(customer);
            string confirmation = create(authModel);
            return confirmation;
        }

        //Next Step
        public string create(AuthModel authModel)
        {
            string type = "We are thrilled to have you on board";
            string Password = Generate().ToString();
            string tblEntry = AssignAuth(authModel, Password);
            string mailStatus = SendMail(authModel, Password,type);

            if(tblEntry == "Success" && mailStatus== "Success") { return "success"; }
            else { return "Error Occurred Inserting Value"; }
            
        }

       

        //This Function will Assign required Data to the Authentication Table
        public string AssignAuth(AuthModel authModel, string password)
        {
            LoginAuthentications auth = new LoginAuthentications();

            auth.AuthToken = authModel.token;
            auth.Status = "Pending";
            auth.Email = authModel.Email.ToString();
            auth.Password = password;
            createAuthentication(auth, "create");

            
            return "Success";
        }

        public void createAuthentication(LoginAuthentications loginAuthentications,string method)
        {

            if(method=="create")
            {
                LoginAuthentications log = unitOfWork.LoginAuthenticationRepository.GetLastRow();
                loginAuthentications.Id = log.Id + 1;
                unitOfWork.LoginAuthenticationRepository.Insert(loginAuthentications);
                
            }
            else if(method == "update")
            {
                loginAuthentications.LastUpdate = DateTime.Now.ToString();
                unitOfWork.LoginAuthenticationRepository.Update(loginAuthentications);
            }

            unitOfWork.Save();

        }

        //This will Send Mail to User notifying him his password
        public string SendMail(AuthModel authModel, string password,string type)
        {
            MailModel mailModel = new MailModel();

            mailModel.MailTo = authModel.Email;
            mailModel.MailSubject = "Welcome to The Phone Store";
            mailModel.MailBody = "<h2>hello " + authModel.Name + "</h2>" +
                                   "<h3>welcome to the Store. "+type+" </br> " +
                                   "The Random Password for you Sign in is <b>" + password + "</b></h3>"+
                                   "<p>Thank You for Staying With us</p>"+
                                   "Mail Sent at " + authModel.IssueDate + "</br>"+
                                   "@copyright Shuorer Baccha ";

            MailConfig conf = new MailConfig();

            string mailStatus = conf.sendUserPassword(mailModel);

            if (mailStatus == "OK") { return "Success"; }
            else { return mailStatus; }

         }

        public string forget(LoginAuthentications loginAuthentications)
        {
            string type = "We are sorry to hear that you've lost your password.";
            string Password = Generate().ToString();
            loginAuthentications.Password = Password;
            
            createAuthentication(loginAuthentications, "update");

            AuthModel authModel = modelCreation.Create(loginAuthentications);
            string mailStatus = SendMail(authModel, Password, type);

            if (mailStatus == "Success") { return "success"; }
            else { return "Error Occurred Inserting Value"; }

        }

        public string changePassword(LoginAuthentications loginAuthentications, UpdatePasswordModel updatePasswordModel)
        {
            string type = "Your Request for changing password was successful. </br> If you believe that this is a mistake, Contact us";
            loginAuthentications.Password =  updatePasswordModel.NewPassword;
            createAuthentication(loginAuthentications, "update");

            AuthModel authModel = modelCreation.Create(loginAuthentications);
            string mailStatus = SendMail(authModel, updatePasswordModel.NewPassword, type);

            if (mailStatus == "Success") { return "success"; }
            else { return "Error Occurred Inserting Value"; }
        }

    }
}