using System;

namespace Paxlava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("isdediyiniz sayi daxil edin : ");
            int say = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= say; i++)
            {
                for (int k = say; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();

            }

            
            for (int i = (say-1); i >= 1; i--)
            {
                for (int k = say; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();

            }
        }
    }
}
