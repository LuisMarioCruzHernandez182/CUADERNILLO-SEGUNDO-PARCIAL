using System;
namespace PAR_IMPAR
{
    class program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("\r\n  ____       _      ____       ___      ___   __  __   ____       _      ____  \r\n |  _ \\     / \\    |  _ \\     / _ \\    |_ _| |  \\/  | |  _ \\     / \\    |  _ \\ \r\n | |_) |   / _ \\   | |_) |   | | | |    | |  | |\\/| | | |_) |   / _ \\   | |_) |\r\n |  __/   / ___ \\  |  _ <    | |_| |    | |  | |  | | |  __/   / ___ \\  |  _ < \r\n |_|     /_/   \\_\\ |_| \\_\\    \\___/    |___| |_|  |_| |_|     /_/   \\_\\ |_| \\_\\\r\n                                                                               \r\n");
            Console.WriteLine("-------------------------------");
            Console.Write("Digite el valor 1: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Digite el valor 2: ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            if (a % 2 == 0)
            {
                Console.WriteLine("El numero "+a+" es par");
            }
            if (b % 2 == 0)
            {
                Console.WriteLine("El numero "+b+" es par");
            }
            if (a % 2 == 1)
            {
                Console.WriteLine("El numero " + a + " es impar");
            }
            if (b % 2 == 1)
            {
                Console.WriteLine("El numero " + a + " es impar");
            }
        }
    }
}