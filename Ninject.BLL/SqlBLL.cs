using Ninject.DAL;
using Ninject.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.BLL
{
    public class SqlBLL : ISqlBLL
    {
        private ISqlDAL sqlDAL;

        public SqlBLL(ISqlDAL _sqlDAL)
        {
            this.sqlDAL = _sqlDAL;
        }

        public string getEmail(int id)
        {
            return this.sqlDAL.getEmail(id);
        }
    }
}
