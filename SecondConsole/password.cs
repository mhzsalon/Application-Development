using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsole
{
    public class password
    {
        public static void nameList()
        {
            string[] names = { "John", "Matt", "Steve"};  

            foreach(var name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
