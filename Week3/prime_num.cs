using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class prime_num
    {
        public void prime()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0 )
                {
                    count++;
                }
            }

            if (count == 2 || num==1)
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }
        }
    }
}
