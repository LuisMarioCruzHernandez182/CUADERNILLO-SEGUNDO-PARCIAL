using System;
namespace ESFERA
{
    class program
    {
        static void Main(string[] args)
        {
            double area,radio;
            char op;
            do
            {
                Console.WriteLine("  _     ___   ___     _       ___    ___     _   _   _  _     _       ___   ___   ___   ___   ___     _   \r\n   /_\\   | _ \\ | __|   /_\\     |   \\  | __|   | | | | | \\| |   /_\\     | __| / __| | __| | __| | _ \\   /_\\  \r\n  / _ \\  |   / | _|   / _ \\    | |) | | _|    | |_| | | .` |  / _ \\    | _|  \\__ \\ | _|  | _|  |   /  / _ \\ \r\n /_/ \\_\\ |_|_\\ |___| /_/ \\_\\   |___/  |___|    \\___/  |_|\\_| /_/ \\_\\   |___| |___/ |_|   |___| |_|_\\ /_/ \\_\\\r\n                                                                                                            ");
                Console.Write("DIGITE EL RADIO DE LA ESFERA: ");
                radio = double.Parse(Console.ReadLine());
                if (radio >= 1)
                {
                    area = Math.PI * (Math.Pow(radio, 2));
                    Console.WriteLine("El area de la esfera es de: " + area);
                }
                   
                else
                {
                    Console.WriteLine("No es posible sacar un valor con 0 o menos");
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("Desea realizar otra operacion?");
                Console.WriteLine("s o n");
                Console.WriteLine("------------------------------");
                op= char.Parse(Console.ReadLine());
                if (op == 'n')
                {
                    Console.WriteLine("                         _                                                    _           \r\n __   __  _   _    ___  | | __   __   __ _     _ __    _ __    ___    _ __   | |_    ___  \r\n \\ \\ / / | | | |  / _ \\ | | \\ \\ / /  / _` |   | '_ \\  | '__|  / _ \\  | '_ \\  | __|  / _ \\ \r\n  \\ V /  | |_| | |  __/ | |  \\ V /  | (_| |   | |_) | | |    | (_) | | | | | | |_  | (_) |\r\n   \\_/    \\__,_|  \\___| |_|   \\_/    \\__,_|   | .__/  |_|     \\___/  |_| |_|  \\__|  \\___/ \r\n                                              |_|                                         ");
                }
                if(op == 's')
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida, se te regresara al inicio");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            } while (op!='n');
            
           
        }
    }
}