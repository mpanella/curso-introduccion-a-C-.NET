using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio3
{
    class Program
    {
        static void ejercicio1()
        {
            // imprimir los numeros del 1 al 10 uno bajo el otro

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ejercicio2()
        {
            // imprimir los numeros del 1 al 10 salteando de a 2 uno bajo el otro

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        static void ejercicio3()
        {
            // imprimir los numeros del 10 al 1 uno debajo del otro

            int x = 10;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(x);
                x--;
            }
        }

        static void ejercicio4()
        {
            //imprimir lo snumeros del 1 al 10 sin imprimir los numeros 2,5,9 uno debajo del otro

            for(int i = 1; i <= 10; i++)
            {
                if(i != 2 && i !=5 && i != 9)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ejercicio5()
        {
            // imprimir los numeros del 1 al 30 sin imprimir numeros entre el 10 y el 20 uno bajo del otro

            for(int i = 1; i <= 30; i++)
            {
                if(i <=10 || i >= 20)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ejercicio6()
        {
            // imprimir la suma de los numeros del 1 al 10 
            int suma = 0;
            for(int i = 1; i <= 10; i++)
            {
                suma += i;
            }
            Console.WriteLine("la suma de los numeros del 1 al 10 es : {0}", suma);
        }

        static void ejercicio7()
        {
            // imprimir la suma de los numeros pares del 1 al 25

            int suma = 0;

            for(int i = 1; i <= 25; i++)
            {
                if(i%2 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("la suma de los numeros pares es : {0}", suma);
        }

        static void ejercicio8()
        {
            // imprimir la multiplicacion de los impares que se encuentren entre -10 y 10

            int multi = 0;
            int x = -10;
            for(int i = 1 ; i <= 20; i++)
            {
                if( x%2 != 0)
                {
                    multi = multi * x;
                    x++;
                }
            }
            Console.WriteLine("la multiplicacion de los impares es : {0}", multi);
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
            ejercicio8();
            Console.ReadKey();
        }
    }
}
