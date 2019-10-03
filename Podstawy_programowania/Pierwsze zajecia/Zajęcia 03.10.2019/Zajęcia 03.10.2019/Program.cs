using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_03._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz

            /*
             * 1   
             *  2
             * 3
             * 4
             */
            Console.WriteLine("Janusz");
          

            //Zmienne i typy danych
            int x1 = 10;
            int y = 15;
            int z = 20;
            Console.Write("zmienna: ");
            Console.WriteLine(x1);
            
            

            //Konkatenacja:
            Console.WriteLine("y = " + y + "\nz = z " + z);

            int a = 10;
            int b = a;
            Console.WriteLine(a + " " + b);

            //alternatywny sposób deklaracji zmiennej
            //int c = 0;

            int c = new int(); //wartość domyślna ==> null - brak referencji
            Console.WriteLine("Wartość zmiennej c " + c);

            Console.WriteLine("Podaj Swoje imię : ");
            string name = Console.ReadLine();
            Console.WriteLine("Twoje imię : " + name);


            int z1 = 12;

            uint z2 = 20; 

            float y1 = 5.5F;

            double y2 = 10.95;


            Console.WriteLine("Zmienna y1 = " + y1);
            Console.WriteLine("Zmienna y2 = " + y2);

            /*
             * oblicz pole prostokąta którego dane podaje użytkownik
             */
         

            Console.WriteLine("Podaj bok A: ");
            double bokA = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok B: ");
            double bokB = double.Parse(Console.ReadLine());
            //double result = bokA * bokB;
            //Console.WriteLine("Pole wynosi: " + result);

            //bokA *= bokB;
            //Console.WriteLine("Pole wynosi: ");





            Console.ReadKey();
        }
    }
}