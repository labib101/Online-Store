using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace MobileStore.MailService
{
    public class MailConfig: PrepareEmail
    {

        public string sendUserPassword(MailModel mailModel)
        {

            SmtpClient client = obtainProtocol();
            MailMessage msg = AssignMessage(mailModel);
            
            try
            {
                client.Send(msg);
                return "OK";
            }
            catch (Exception ex)
            {
                return "error:" + ex.ToString();
            }
        }
    }
}