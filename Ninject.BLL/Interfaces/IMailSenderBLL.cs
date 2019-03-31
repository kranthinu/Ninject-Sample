using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.BLL
{
    public interface IMailSenderBLL
    {
        void Send(string toAddress, string subject, string body);
    }
}