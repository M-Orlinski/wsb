using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @continue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int j = 1;
            for(; j <=10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    continue;
                else
                    Console.WriteLine("{0} ", j);
            }
            Console.WriteLine();
            */

            int j = 0;
            for (; j <= 10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    break;
                else
                    Console.WriteLine("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}
