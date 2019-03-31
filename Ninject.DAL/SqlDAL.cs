using Ninject.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.DAL
{
    public class SqlDAL : ISqlDAL
    {
        public string getEmail(int id)
        {
            //Get data from Database
            var students = new List<Students>();
            students.Add(new Students() { ID = 1, FirstName = "Alan", LastName = "Donald", Age = 20, Email = "Alan.Donald@gmail.com" });
            students.Add(new Students() { ID = 2, FirstName = "Stephen", LastName = "Miller", Age = 22, Email = "Stephen.Miller@gmail.com" });
            students.Add(new Students() { ID = 3, FirstName = "Ben", LastName = "Stokes", Age = 24, Email = "Ben.Stokes@gmail.com" });
            students.Add(new Students() { ID = 4, FirstName = "Brett", LastName = "Lee", Age = 26, Email = "Brett.Lee@gmail.com" });

            return students.Where(x => x.ID == id).Select(x=>x.Email).FirstOrDefault();
        }
    }
}
