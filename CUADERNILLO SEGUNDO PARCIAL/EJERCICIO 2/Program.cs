using System;
namespace TAQUERIA
{
    class program
    {
        static void Main(string[] args)
        {
            int tac,a,boli,b, burri,c, ques,d,tort,e;
            double ct=0,ctd=0;
            char tarj;
            Console.WriteLine("°°TAQUERIA°°");
            Console.WriteLine("# TORTAS..........$45");
            Console.WriteLine("# TACOS...........$40");
            Console.WriteLine("# BOLILLO.........$20");
            Console.WriteLine("# BURRITOS........$55");
            Console.WriteLine("# QUESADILLAS.....$18");
            Console.WriteLine("-----------------");
            Console.Write("Cuantos Tacos desea?: ");
            tac = int.Parse(Console.ReadLine());
            Console.Write("Cuantos Bolillos desea?: ");
            boli = int.Parse(Console.ReadLine());
            Console.Write("Cuantos Burritos desea?: ");
            burri = int.Parse(Console.ReadLine());
            Console.Write("Cuantas Quesadillas desea?: ");
            ques = int.Parse(Console.ReadLine());
            Console.Write("Cuantas Tortas  desea?: ");
            tort= int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");
            a = tac * 40;
            b = boli * 20;
            c = burri * 55;
            d = ques * 18;
            e = tort * 45;
            Console.WriteLine("Usted posee tarjeta?: ");
            tarj =char.Parse(Console.ReadLine());
            if (tarj == 's')
            {               
                ct = a + b + c + d + e;
                ctd = ct - (ct * 0.05);
            }
            else if (tarj == 'n')
            {
                ct= a + b + c + d + e;
            }
            Console.WriteLine("El costo total con descuento es: "+ctd);
            Console.WriteLine("El costo total sin descuento es de: " + ct);




        }
    }
}