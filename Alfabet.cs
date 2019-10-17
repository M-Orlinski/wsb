using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = 'A';
            for(; x <= 'Z'; x++)
            {
                
                if(x != 'Z')
                    Console.Write("{0}, ", x);
                else
                    Console.Write("{0}. ", x);

            }
            Console.Write();
            x--;

            for(; x >= 'A'; x--)
            {
                if(x!='A')
                        Console.Write("{0}, ", x);
                    else
                        Console.Write("{0}. ", x);
            }
            Console.ReadKey();
        }
    }
}
