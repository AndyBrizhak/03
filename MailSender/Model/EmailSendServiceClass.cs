using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    class EmailSendServiceClass
    {
        public string Status { get; private set; } = "Ok";
        public string ErrorInfo { get; private set; } = "";
        /// <summary>
        /// Method 
        /// </summary>
        /// <param name="eMailInfo"></param>
        /// <returns></returns>
        public bool    Send(EMailInfo eMailInfo)
        {
            MailMessage mm = new MailMessage(eMailInfo.From, eMailInfo.To);
            mm.Subject = eMailInfo.Subject;
            mm.Body = eMailInfo.Body;
            mm.IsBodyHtml = false;

            
            SmtpClient sc = new SmtpClient(eMailInfo.SMTPClient, eMailInfo.Port);
            sc.EnableSsl = true;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            sc.Credentials = new NetworkCredential(eMailInfo.Sender, eMailInfo.Password);
            try
            {
                sc.Send(mm);
            }
            catch (Exception exc)
            {
                Status=exc.Message;
                ErrorInfo = exc.StackTrace;
                return false;
            }
            Status = "Ok";
            return true;

        }

    }
}
