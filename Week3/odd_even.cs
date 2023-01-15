using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class odd_even
    {
        public void oddEven()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("it is an odd number");
            }
        }
    }
}
