using System;

namespace Estructura_de_constro__Semana_3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            string continuar;

            do
            {
                Console.WriteLine("|*************************************************|");
                Console.WriteLine("|*                                               *|");
                Console.WriteLine("|*       1.-Suma dos numeros (A + B)             *|");
                Console.WriteLine("|*       2.-reste dos numeros (A - B)            *|");
                Console.WriteLine("|*       3.-Multiplique dos numeros (A * B)      *|");
                Console.WriteLine("|*       4.-Divida dos numeros (A / B)           *|");
                Console.WriteLine("|*       5.-Todas las Operaciones                *|");
                Console.WriteLine("|*                                               *|");
                Console.WriteLine("|*       0.-salir                                *|");
                Console.WriteLine("|*                                               *|");
                Console.WriteLine("|*                                               *|");
                Console.Write("\n");
                Console.Write("Dime una opcion:   ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '5');
                switch(opcion)
                {
                    case 'o':
                        {
                            Environment.Exit(0);
                            
                        }
                        break;
                    case'1':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            ClassOP op= new ClassOP(numeroA, numeroB);
                            Console.WriteLine("El resultado de la suma es:" + op.opsuma().ToString());

                        }
                        break;
                    case '2':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            ClassOP op = new ClassOP(numeroA, numeroB);
                            Console.WriteLine("El resultado de la resta es:" + op.opresta().ToString());

                        }
                        break;
                    case '3':

                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            ClassOP op = new ClassOP(numeroA, numeroB);
                            Console.WriteLine("El resultado de la Multiplicacion es:" + op.opmultiplicar().ToString());

                        }

                        break;
                    case '4':

                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            ClassOP op = new ClassOP(numeroA, numeroB);
                            Console.WriteLine("El resultado de la division es:" + op.opdividir().ToString());

                        }

                        break;

                    case '5':

                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("--------------------");

                            Console.Write("ingrese el numero (A):");
                            double numeroA = double.Parse(Console.ReadLine());

                            Console.Write("ingrese el numero (B):");
                            double numeroB = double.Parse(Console.ReadLine());

                            Console.WriteLine("------------------------");
                            ClassOP op = new ClassOP(numeroA, numeroB);
                            Console.WriteLine("El resultado de la suma es           :" + op.opsuma().ToString());
                            Console.WriteLine("El resultado de la resta es          :" + op.opresta().ToString());
                            Console.WriteLine("El resultado de la Multiplicacion es :" + op.opmultiplicar().ToString());
                            Console.WriteLine("El resultado de la division es       :" + op.opdividir().ToString());
                        }
                        break;
                }
                Console.WriteLine("*********************************");
                Console.Write("¿deseas continuar? Si/No");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");
        }
    }
}
