using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.DAL
{
    public interface ISqlDAL
    {
        string getEmail(int id);
    }
}
