using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.Net;

namespace AppTestSMTPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Utils.MailUtility.SentEmail("Subject Test", "Body of test message", to: new List<string>() { Properties.Settings.Default.ToAddress });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in configurations, please check...");
            }
            
            
            Console.ReadLine();
            
        }
    }
}
