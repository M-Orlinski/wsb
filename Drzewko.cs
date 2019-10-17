using System;

namespace choinka_10._10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj wysokość choinki: ");
            string ile = Console.ReadLine();
            int ile1;
            Console.WriteLine("Z jakich znaków ma być choinka: ");
            string znak = Console.ReadLine();
            char znak1;


            if (char.TryParse(znak, out znak1))
            {
                if (int.TryParse(ile, out ile1))
                {
                    for (int i = 1; i <= ile1; i++)
                    {
                        for (int j = 1; j <= i + ile1; j++)
                        {
                            if (j > ile1 - i)

                                Console.Write(znak1);
                            else
                                Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }

            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}