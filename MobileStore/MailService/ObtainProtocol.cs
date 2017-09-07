using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace MobileStore.MailService
{
    public class ObtainProtocol
    {
        public SmtpClient obtainProtocol()
        {
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            System.Net.NetworkCredential credentials =
            new System.Net.NetworkCredential("hellodoctorofficial@gmail.com", "tiger321");
            client.UseDefaultCredentials = false;
            client.Credentials = credentials;

            return client;
        }
    }
}