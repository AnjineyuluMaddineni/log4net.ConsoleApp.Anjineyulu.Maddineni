using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net.ConsoleApp.Anjineyulu.Maddineni
{
    class Program
    {
       internal static void Testing()
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog log = log4net.LogManager.GetLogger(typeof(Program));
     
            try
            {
                object o2 = null;
                int i2 = (int)o2;   // Error
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
            
        }
        static void Main(string[] args)
        {
            Testing();
            Console.ReadLine();
        }
    }
}
