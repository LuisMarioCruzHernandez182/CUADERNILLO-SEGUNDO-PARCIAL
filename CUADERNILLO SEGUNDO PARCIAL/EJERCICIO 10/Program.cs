using System;
namespace CALCULADORA
{
    class program
    {
        static void Main(string[] args)
        {
            double a, b, tot=0;
            int op;
            char ob;
            do
            {
                Console.WriteLine("  ____      _      _        ____   _   _   _          _      ____     ___    ____       _    \r\n  / ___|    / \\    | |      / ___| | | | | | |        / \\    |  _ \\   / _ \\  |  _ \\     / \\   \r\n | |       / _ \\   | |     | |     | | | | | |       / _ \\   | | | | | | | | | |_) |   / _ \\  \r\n | |___   / ___ \\  | |___  | |___  | |_| | | |___   / ___ \\  | |_| | | |_| | |  _ <   / ___ \\ \r\n  \\____| /_/   \\_\\ |_____|  \\____|  \\___/  |_____| /_/   \\_\\ |____/   \\___/  |_| \\_\\ /_/   \\_\\\r\n                                                                                              ");
                Console.WriteLine("Ingrese el valor numero 1: ");
                a=double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor numero 2: ");
                b=double.Parse(Console.ReadLine());            
                Console.WriteLine("------------------------------");
                Console.WriteLine("°°1. SUMA°°");
                Console.WriteLine("°°2. RESTA°°");
                Console.WriteLine("°°3. MULTIPLICACION°°");
                Console.WriteLine("°°4. DIVISION°°");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Que operacion desea realizar?");
                op=int.Parse(Console.ReadLine());   
                switch (op)
                {
                    case 1:
                        tot = a + b;                       
                        break;
                    case 2:
                        tot = a - b;    
                        break ;
                    case 3:
                        tot = a * b;
                        break;
                    case 4:
                        tot = a / b;
                        break;               
                }
                Console.WriteLine("El resultado de la operacion es: "+tot);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Desea realizar otra operacion?");
                Console.WriteLine("s o n?");
                ob=char.Parse(Console.ReadLine());
                if (ob == 'n')
                {
                    Console.WriteLine("  _   _      _      ____    _____      _        _       _   _   _____    ____    ___  \r\n | | | |    / \\    / ___|  |_   _|    / \\      | |     | | | | | ____|  / ___|  / _ \\ \r\n | |_| |   / _ \\   \\___ \\    | |     / _ \\     | |     | | | | |  _|   | |  _  | | | |\r\n |  _  |  / ___ \\   ___) |   | |    / ___ \\    | |___  | |_| | | |___  | |_| | | |_| |\r\n |_| |_| /_/   \\_\\ |____/    |_|   /_/   \\_\\   |_____|  \\___/  |_____|  \\____|  \\___/ \r\n                                                                                      ");                    
                }
                else if(ob == 's')
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida, se le regresara al inicio");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            } while(ob!='n');
        }

    }
}