using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabliczka_mnożenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int row = 1;
            int col;

            
            do
            {
                col = 1;
                do
                {
                    Console.Write(row * col + "\t");
                    col++;
                }
                while (col <= n);
                row++;
                Console.WriteLine( );
            }
            while (row <= 10);
            
            Console.ReadKey();
           

           
        }
    }
}
