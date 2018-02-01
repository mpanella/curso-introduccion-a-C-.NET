using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilizacionDeLaEstructuraDeControl
{
    class Program
    {
        static void ejercicio1()
        {
            // imprimir los numeros del 1 al 10 uno debajo del otro

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ejercicio2()
        {
            //imprimir los numeros del 1 al 10 salteando de dos en dos uno bajo el otro

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                i++;


            }
        }

        static void ejercicio3()
        {
            //imprimir los numeros del 10 al 1 uno bajo el otro
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void ejercicio4()
        {
            // imprimir la suma de los numeros impares
            int suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("la suma de los impares es : " + suma);
        }

        static void ejercicio5()
        {
            //mostrar la resta de la multiplicacion de los numeros del 1 al 5 con la suma de los numeros del 1 al 5
            int multi = 1;
            int suma = 0;
            int total = 0;

            for(int i = 1; i <= 5; i++)
            {
                multi = multi * i;
                suma += i;
            }
            Console.WriteLine("la suma es : {0} y la multiplicacion {1}", suma, multi);
            total = multi - suma;
            Console.WriteLine("la resta da : " + total);

        }

        static void ejercicio6()
        {
            // imprimir la siguiente figura
            /*
             * @
             * 
             * @
             * 
             * @
             * 
             * @
             * 
             */

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("@");
                
            }

        }

        static void ejercicio7()
        {
            /*imprimir la siguiente figura
             *
             * @
             * 
             * @@
             * 
             * @
             * 
             * @@
             * 
             * @
             * 
             */

            for(int i = 1; i <=5; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("@");
                }
                else
                    Console.WriteLine("@@");
            }

        }

        static void ejercicio8()
        {
            /* imprimir la siguiente figura
             * @
             * @@
             * @@@
             * @@@@
             * @@@@@
             */

            string a = "@";
             for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(a);
                a += "@";

            }
        }

        static void ejercicio9()
        {
            /* imprimir la siguiente figura
             * @@@@@
             * @@@@
             * @@@
             * @@
             * @
             */
             for(int i = 0; i < 5; i++)
            {
                for(int j = 5 ; j > i; j--)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }

        static void ejercicio10()
        {
            /*imprimir la siguiente figura
             * @
             * @@
             * @@@
             * @@@@
             * @@@
             * @@
             * @
             */
            string a = "@";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a);
                a += "@";

            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 3; j > i; j--)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }

        static void ejercicio11()
        {
            /* imprimir la siguiente imagen
             * @@@@@
             * @@@
             * @
             * @@@
             * @@@@@
             */

            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("@");
                    
                }
                i++;

                Console.WriteLine();
            }

            string a = "@@@";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(a);
                a += "@@";

            }

        }

        static void Main(string[] args)
        {
            //ejercicio1();
            //ejercicio2();
            //ejercicio3();
            //ejercicio4();
            //ejercicio5();
            //ejercicio6();
            //ejercicio7();
            ejercicio11();
            Console.ReadKey();
        }
    }
}
