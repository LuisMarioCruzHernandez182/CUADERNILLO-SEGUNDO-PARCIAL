using System;
namespace Mayoreo
{
    class program
    {
        static void Main(string[] args)
        {
            double plat, prec, tot = 0;
            Console.WriteLine("°°Escriba la cantidad de platos a llevar°°");
            plat = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el precio por plato");
            prec = double.Parse(Console.ReadLine());
            if (plat >= 48)
            {
                tot = (plat * prec) - ((plat * prec) * 0.20);
            }
            else if (plat < 48)
            {
                tot = (plat * prec) - ((plat * prec) * 0.08);
            }
            else
            {
                Console.WriteLine("La opcion ingresada no es valida");
            }
            Console.WriteLine("El total a pagar seria de: $" + tot);
        }
        
    }
}