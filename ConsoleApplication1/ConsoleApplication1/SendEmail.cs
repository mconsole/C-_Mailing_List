using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;

namespace EmailMessenger
{
    class SendEmail
    {
        public static void EmailSend() {

            MailMessage msg = new MailMessage();

            Console.WriteLine("Please enter the subject text:");
            msg.Subject = Console.ReadLine();

            Console.WriteLine("Please enter the email body text:");
            msg.Body = Console.ReadLine();

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(@"C:\Code Projects\C#\Email Messanger\Emails.txt"))
                {
                    string line;
                    // Read and add lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        msg.To.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            // Set email server address and port
            var server = "";
            int port = 0;

            SmtpClient smtp = new SmtpClient(server, port);
            smtp.Send(msg);
        }
    }
}
