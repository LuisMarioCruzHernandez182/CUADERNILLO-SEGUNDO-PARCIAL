using System;
namespace ESTACIONAMIENTO
{
    class program
    {
        static void Main(string[] args)
        {

            double hrs,tot;
            Console.WriteLine("°°ESTACIONAMIENTO°°");
            Console.Write("Escriba la cantidad de horas que va a pasar estacionado: ");
            hrs = double.Parse(Console.ReadLine());

            if (hrs > 0)
            {
                tot = hrs * 40;
                Console.WriteLine("El precio a pagar sera de: " + tot+ "hrs");
            }
            else
                Console.WriteLine("Las horas ingresadas no son validas: ");
        }

    }
}