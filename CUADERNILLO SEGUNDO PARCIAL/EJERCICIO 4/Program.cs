using System;
namespace PRESUPUESTO
{
    class program
    {
        static void Main(string[] args)
        {
            double presu;
            Console.WriteLine("  ____    _____    ____      _      _        ___  \r\n |  _ \\  | ____|  / ___|    / \\    | |      / _ \\ \r\n | |_) | |  _|   | |  _    / _ \\   | |     | | | |\r\n |  _ <  | |___  | |_| |  / ___ \\  | |___  | |_| |\r\n |_| \\_\\ |_____|  \\____| /_/   \\_\\ |_____|  \\___/ \r\n                                                  ");
            Console.WriteLine("REGALOS DISPONIBLES");
            Console.WriteLine("|Chocolates..............$50 |");
            Console.WriteLine("|Cartera................$100 |");
            Console.WriteLine("|Playera................$150 |");
            Console.WriteLine("|Zapatos................$250 |");
            Console.WriteLine("--------------------------------");
            Console.Write("Escriba la cantidad del presupuesto del que dispone: ");
            presu=double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            if (presu < 50)
            {
                Console.WriteLine("#No le alcanza actualmente para nada");
            }
            if(presu >=50)
            {
                Console.WriteLine("#Le alcanza para unos chocolates");
            }
            if(presu>=100)
            {
                Console.WriteLine("#Le alcanza para una cartera");
            }
            if (presu >= 150)
            {
                Console.WriteLine("#Le alcanza para una playera");
            }
            if (presu >= 250)
            {
                Console.WriteLine("#Le alcanza para un par de zapatos");
            }           
        }
    }
}