using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsole
{
    public class SecondClass
    {
        public static string secondMethod() {

            Console.WriteLine("Enter the value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter tha value of y: ");
            var y  = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                return "x is smaller than y";
            }
            else if (x > y) 
            {
                return "x is greater than y";
            }
            else if (x %2 == 0){
                return "x num is even number";
            }
            else
            {
               return "Error";
            }
        }

        public static string password()
        {
            String? password;
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            } while (password != "SecretPassword");

            return "Welcome!";

        }
    }
}
