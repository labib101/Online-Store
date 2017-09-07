using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace MobileStore.MailService
{
    public class PrepareEmail:ObtainProtocol
    {
        public MailMessage AssignMessage(MailModel mailModel)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("hellodoctorofficial@gmail.com");
            msg.To.Add(new MailAddress(mailModel.MailTo));

            msg.Subject = mailModel.MailSubject;
            msg.IsBodyHtml = true;
            msg.Body = mailModel.MailBody;

            return msg;
        }
    }
}