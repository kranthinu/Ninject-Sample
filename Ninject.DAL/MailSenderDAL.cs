using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.DAL
{
    public class MailSenderDAL :IMailSenderDAL
    {
        public void Send(string toAddress, string subject, string body)
        {
            //Code to send an email using SFTP

            Console.WriteLine("Sending mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
