using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var Email = "";
            var email = "";

            Console.WriteLine("Please enter your email address");
            email = Console.ReadLine();

            if (email == "" || email == null)
            {
                Console.WriteLine("Please enter a valid email adddress");
                email = Console.ReadLine();
            } else
            {
                Email = email.ToUpper();
            }

            OpenFile.WriteFile(Email);

            SendEmail.EmailSend();

        }
    }
}
