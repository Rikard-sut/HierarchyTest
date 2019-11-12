using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHuman
{
    static class Extensions
    {
        public static void Print (this IEnumerable<object> list)
        {
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
