using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmailMessenger
{
    class OpenFile
    {
        // Method for adding emails to a file
        public static void WriteFile(string email)
        {
            string path = @"C:\Code Projects\C#\Email Messanger\Emails.txt";
            var Email = email;

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("File created {0}", DateTime.Now);
                }
            } 

            // This text is always added, making the file longer over time
            
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(Email);
                    Console.WriteLine("Thank you! Your email has been added to the list.");
                }
            }
            else
            {
                Console.WriteLine("Save file not found");
            }
        }

        // Method for reading the email file
        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
