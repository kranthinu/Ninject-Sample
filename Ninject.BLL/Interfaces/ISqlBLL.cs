using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.BLL
{
    public interface ISqlBLL
    {
        string getEmail(int id);
    }
}