using Ninject.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var kernel = new StandardKernel();
                kernel.Load(Assembly.GetExecutingAssembly());

                var controllerBll = kernel.Get<IControllerBLL>();

                Random random = new Random();
                var id = random.Next(1, 10);

                controllerBll.process(id);
            }
            catch (Exception ex)
            {
                //Log the exception here
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}