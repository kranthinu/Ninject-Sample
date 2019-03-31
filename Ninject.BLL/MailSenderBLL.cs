using Ninject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.BLL
{
    public class MailSenderBLL : IMailSenderBLL
    {
        private IMailSenderDAL mailSenderDAL;

        public MailSenderBLL(IMailSenderDAL _mailSenderDAL)
        {
            this.mailSenderDAL = _mailSenderDAL;
        }

        public void Send(string toAddress, string subject, string body)
        {
            this.mailSenderDAL.Send(toAddress, subject, body);
        }
    }
}