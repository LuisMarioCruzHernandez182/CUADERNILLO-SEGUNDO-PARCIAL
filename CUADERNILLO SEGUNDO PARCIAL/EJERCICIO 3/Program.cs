using System;
namespace transporte
{
    class program
    {
        static void Main(string[] args)
        {
            int edad, cf=0;
            Console.WriteLine("  _____   ____       _      _   _   ____    ____     ___    ____    _____   _____ \r\n |_   _| |  _ \\     / \\    | \\ | | / ___|  |  _ \\   / _ \\  |  _ \\  |_   _| | ____|\r\n   | |   | |_) |   / _ \\   |  \\| | \\___ \\  | |_) | | | | | | |_) |   | |   |  _|  \r\n   | |   |  _ <   / ___ \\  | |\\  |  ___) | |  __/  | |_| | |  _ <    | |   | |___ \r\n   |_|   |_| \\_\\ /_/   \\_\\ |_| \\_| |____/  |_|      \\___/  |_| \\_\\   |_|   |_____|\r\n                                                                                  ");
            Console.WriteLine("|MAYORES DE 10 AÑOS.......$25|");
            Console.WriteLine("|MENORES DE 10 AÑOS.......$12|");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("DIGITE LA EDAD: ");
                edad = int.Parse(Console.ReadLine());
                if (edad >= 10)
                {
                    cf = cf + 25;
                }
                else if (edad < 10)
                    cf = cf + 12;
            }
            Console.WriteLine("El costo total es: " + cf);
            
        }
    }
}