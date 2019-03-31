using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.DataModel;

namespace Ninject.BLL
{
    public class ControllerBLL : IControllerBLL
    {
        private readonly ISqlBLL sqlBLL;
        private readonly IMailSenderBLL mailSenderBLL;

        public ControllerBLL(ISqlBLL _sqlBLL, IMailSenderBLL _mailSenderBLL)
        {
            this.sqlBLL = _sqlBLL;
            this.mailSenderBLL = _mailSenderBLL;
        }

        public void process(int id)
        {
            var email = this.sqlBLL.getEmail(id);

            if (!string.IsNullOrWhiteSpace(email))
            {
                this.mailSenderBLL.Send(email, "Subject Text", "Body Text");
            }
            else
            {
                this.mailSenderBLL.Send("internalEmail@gmail.com", "Subject Text", "Body Text");

                throw new Exception(string.Format("Invalid id found {0}", id));
            }
        }
    }
}