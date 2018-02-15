using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusWhile
{
    class Program
    {
        static void Ejercicio1()
        {
            //Mostrar la suma de los numeros pares mayores a 9 y menores a 20

            int suma = 0;

            for(int i = 1; i <= 20; i++)
            {
                if(i < 20 && i > 9)
                {
                    if(i % 2 == 0)
                    {
                        suma += i;
                    }
                }
            }

            Console.WriteLine("La suma de los numeros pares entre 9 y 20 es : " + suma);
        }

        static void ejercicio2()
        {
            //Mostrar la convercion de 1 hasta 10 euros en pesos,euro tras euro , suponiendo
            // que el tipo de cambio es 5. 80

            double euro = 0;
            double cambio = 5.80;
           
            for (int i = 1; i <= 10; i++)
            {
                euro = 0;
                euro = i * cambio;

                Console.WriteLine("{0} euro  son {1} pesos", i, euro);
            }
        }

        static void ejercicio3()
        {
            /**una persona desea invertir $1000 en un banco , el cual le otorga un 2%
             * de interes mensual Cual sera la cantidad de dinero que esta persona tendra
             * al cabo de un año ? En el primer mes tendra acumulado 1000$ mas 20% de interes
             * (2% de 1000).En el segundo mes se le sumara un 2% a la base de 1020$ del mes
             * anterior y asi susesivamente 
             * */

            double invercion = 1000;
        

            for( int i = 1; i <= 12; i++)
            {
                invercion  += invercion * 0.02;

                Console.WriteLine(" el mes {0} tendra ${1}", i, invercion);
            }

            Console.WriteLine(" en un año tendra " + invercion);
        }

        static void ejercicio4()
        {
            /* Una persona desea invertir $1000 en un banco, el cual le otorga un 3% de 
             * interes mensual . En cuantos meses conseguira $1200, si reinvierte cada mes
             * todo su dinero
             * */

            double invercion = 1000;
            double interes = 0.03;
            int mes = 0;

            do
            {
                invercion += invercion * interes;
                mes++;
            } while (invercion < 1200);

            Console.WriteLine(" la suma que tienes son ${0} y llevo {1} meses  ", invercion, mes);
        }

        static void ejercicio5()
        {
            /* Desarrolla el codigo que permita a una persona ingresr como maximo tres veces
             * su contraseña . en Caso de ingreso incorrecto debera exibirse la leyenda
             * Bienvenido caso contrario se mostrara "tres veces fallidad" indicar
             * cuantas posivilidades de ingreso el codigo le queda.Por ejemplo si tiene 2
             * posivilidades informar "tiene 2 chances" y si le queda una "Atencion 
             * ultima oportunidad "*/

            String clave = "1234";
            String pass = "";
            int chance = 3;
            do
            {
                Console.Write("ingrese la clave : ");
                pass = Console.ReadLine();

                if (pass == clave)
                {
                    Console.WriteLine("BIENVENIDO !!!");
                    break;
                }
                else
                    chance--;
                    if(chance == 2)
                {
                    Console.Write("te quedan 2 chances");
                }
                    if(chance == 1)
                {
                    Console.WriteLine("Atencion solo te queda un intento !! ");
                }
            
            } while (chance != 0);
            if(chance == 0)
            {
                Console.WriteLine("clave bloqueada !!");
            }
        }
        static void Main(string[] args)
        {
            //Ejercicio1();
            //ejercicio2();
            //ejercicio3();
            //ejercicio4();
            ejercicio5();
            Console.ReadKey();
        }
    }
}
