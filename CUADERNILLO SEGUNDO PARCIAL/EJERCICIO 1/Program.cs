using System;
using System.Diagnostics;
using System.Xml.Schema;

namespace SABRITAS
{
    class program
    {
        static void Main(string[] args)
        {
            
                double total = 0, op, cambio;
                double b, toma, c, frij;
                int a, refre, d, sabr, e, gall;
                char du;
            do
            {
                Console.WriteLine("\r\n     _      ____       _      ____    ____     ___    _____   _____   ____  \r\n    / \\    | __ )     / \\    |  _ \\  |  _ \\   / _ \\  |_   _| | ____| / ___| \r\n   / _ \\   |  _ \\    / _ \\   | |_) | | |_) | | | | |   | |   |  _|   \\___ \\ \r\n  / ___ \\  | |_) |  / ___ \\  |  _ <  |  _ <  | |_| |   | |   | |___   ___) |\r\n /_/   \\_\\ |____/  /_/   \\_\\ |_| \\_\\ |_| \\_\\  \\___/    |_|   |_____| |____/ \r\n                                                                            \r\n");
                Console.WriteLine("");
                Console.WriteLine("|REFRESCO DE 3L.....$35|");
                Console.WriteLine("|KG DE TOMATE.......$15|");
                Console.WriteLine("|KG DE FRIJOL.......$30|");
                Console.WriteLine("|SABRITAS...........$16|");
                Console.WriteLine("|GALLETAS...........$14|");
                Console.WriteLine("------------------------");
                Console.Write("Cuantos refrescos de 3 litros desea llevar?: ");
                refre = int.Parse(Console.ReadLine());
                a = refre * 35;

                Console.Write("Cuantos Kg de tomate desea llevar?: ");
                toma = double.Parse(Console.ReadLine());
                b = toma * 15;

                Console.Write("Cuantos Kg de frijol desea llevar?: ");
                frij = double.Parse(Console.ReadLine());
                c = frij * 30;

                Console.Write("Cuantas sabritas desea llevar?: ");
                sabr = int.Parse(Console.ReadLine());
                d = sabr * 16;

                Console.Write("Cuantas galletas desea llevar?: ");
                sabr = int.Parse(Console.ReadLine());
                e = sabr * 14;
                Console.WriteLine("------------------------------");
                Console.Write("Con cuanto va a pagar?:");                
                cambio = double.Parse(Console.ReadLine());
                total = a + b + c + d + e;
                if (total > cambio)
                {
                    Console.WriteLine("A usted no le alcanza el dinero, regrese despues....");
                }
                else if (total < cambio)
                {
                    Console.Clear();
                    Console.WriteLine("Usted va a llevar: ");
                    Console.WriteLine("Refrescos: " + a + " envase o envases de 3 litros");
                    Console.WriteLine("Tomate: " + b+" kg");
                    Console.WriteLine("Frijol: " + c+ " kg");
                    Console.WriteLine("Sabritas: " + d + " paquete o paquetes");
                    Console.WriteLine("Galletas: " + e + " paquete o paquetes");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("El total a pagar seria de: " + total);
                    Console.WriteLine("Su cambio seria de: " + (cambio - total));
                }
                Thread.Sleep(2000);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Desea realizar mas compras?");
                Console.WriteLine("digite 's' o 'n'?");
                du = char.Parse(Console.ReadLine());
                if (du == 'n')
                {
                    Console.WriteLine("                         _                                                    _           \r\n __   __  _   _    ___  | | __   __   __ _     _ __    _ __    ___    _ __   | |_    ___  \r\n \\ \\ / / | | | |  / _ \\ | | \\ \\ / /  / _` |   | '_ \\  | '__|  / _ \\  | '_ \\  | __|  / _ \\ \r\n  \\ V /  | |_| | |  __/ | |  \\ V /  | (_| |   | |_) | | |    | (_) | | | | | | |_  | (_) |\r\n   \\_/    \\__,_|  \\___| |_|   \\_/    \\__,_|   | .__/  |_|     \\___/  |_| |_|  \\__|  \\___/ \r\n                                              |_|                                         ");                  
                }
                if (du == 's')
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida, se le regresara al inicio");
                }
            } while (du!='n');
            


        }

    }
}