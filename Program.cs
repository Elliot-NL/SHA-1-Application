using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHA_1_Application
{
    class Program
    {
        private static string Generator(int hashlength)
        {
            const string Hash = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            char[] chars = new char[hashlength];
            Random rd = new Random();
            for(int i = 0; i<hashlength; i++)
            {
                chars[i] = Hash[rd.Next(0, Hash.Length)];
            }
            return new string(chars);
            
        }
        static void Main(string[] args)
        {
            ///SHA 1 hash is a Secure Hashing Algorithm. 
            ///It is 160 bits long and Creates a random 
            ///hash for any piece of data. 

            Console.WriteLine("Enter Hash Length");
            string uservalue = Console.ReadLine();
            int pass = Convert.ToInt32(uservalue);
            
            Console.WriteLine(Generator(pass));
            Console.ReadLine();
        }
    }
}
