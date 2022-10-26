using System;
namespace ARTICO
{
    class program
    {
        static void Main(string[] args)
        {
            double barb, cer, ape, ct;
            char op;
            do
            {
                Console.WriteLine("°°EL ARTICO°°");
                Console.WriteLine("|KG DE BARBACOA......$280|");
                Console.WriteLine("|SIX DE CERVEZA.......$50|");
                Console.WriteLine("|3 Aperitivos.........$25|");
                Console.WriteLine("------------------------------");

               Console.Write("Cuantos kg de carne necesita? ");
                barb = double.Parse(Console.ReadLine());
                Console.Write("Cuantos Six de Cerveza necesita? ");
                cer = double.Parse(Console.ReadLine());
                Console.WriteLine("Cuantos aperitivos necesita? ");
                ape = double.Parse(Console.ReadLine());
                ape = 25 / 3;
                ct = (barb * 280) + (cer * 50) + ((ape * 3) * 3);
                Console.WriteLine("------------------------------");
                Console.WriteLine("El costo total es de: " + ct);

                Console.WriteLine("Desea realizar mas compras?");
                Console.WriteLine("Digite 's' o 'n'");
                op = char.Parse(Console.ReadLine());

                if (op == 'n')
                {
                    Console.WriteLine("VUELVA PRONTO!!!!");
                }
                else
                {
                    Console.WriteLine("LA OPCION INGRESADA NO ES VALIDA, REGRESARA AL INICIO");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            } while(op!='n');
            
            
        }
    }
}