using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class array
    {
        public string search()
        {
            int [] name = {1,4,8,6,3,10};

            Console.WriteLine("Guess a number (Between 1 to 10): ");
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == value)
                {
                    return "\nCongratulation!! ";
                }
            }

            return "\nError 404 ! \n Number not found";
        }
    }
}
