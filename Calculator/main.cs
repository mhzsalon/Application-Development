using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class main
    {
        public static string addition(int a, int b)
        {

            var c = a + b;

            return ("Sum: " + Convert.ToString(c));
        }

        public static string subtraction(int a, int b)
        {

            var c = a - b;

            return ("sub: " + Convert.ToString(c));
        }

        public static string multiplicaiton(int a, int b)
        {

            var c = a * b;

            return ("mul: " + Convert.ToString(c));
        }
        public static string division(int a, int b)
        {

            var c = a / b;

            return ("duv: " + Convert.ToString(c));
        }
    }

}
