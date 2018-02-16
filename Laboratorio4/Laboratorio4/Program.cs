using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void ejercicio1()
        {
            /*dado el vector {10,20,5,15,30,20}
             * informar el vector de la forma "indice: X , valor : Y
             * totalizar el vector e informar el total
             * informar el contenido de las posiciones impares(por ejemplo , las posiciones 1,3,5,etc)
             * informar el mayor numero
             * informar cuantas veces aparece el numero 20
             * */

            int[] vec =  { 10, 20, 5, 15, 30, 20 };
            int total = 0;
            int mayor = 0;
            int cont = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine("indice: {0}  su Valor : {1}", i, vec[i]);

                total += vec[i];

                if (mayor < vec[i])
                {
                    mayor = vec[i];
                }

                if (vec[i] == 20)
                {
                    cont++;
                }
            }


            Console.WriteLine("\n\n Las posiciones impares son : \n");
            for (int i = 0; i < vec.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("indice: {0}  su Valor : {1}", i, vec[i]);
                }
            }


            Console.WriteLine("\n\n El total del vector es : " + total);
            Console.WriteLine("\n\n El numero mayor es : "+mayor);
            Console.WriteLine("\n\n El numero 20 se repite {0} veces",cont);
        }

        static void ejercicio2()
        {
            /*dado el vector {0.8,0.1,0.3,0.4,0.3,0.6,0.5,0.3,0.7,0.3,0.2,0.9}
             * Cada item del vector representa la inflacion de un mes de tal manera
             * que el primer item del vector reprecenta la inflacion de enero
             * y el ultimo del vector la de diciembre
             * Se pide:
             * informar la inflacion anual
             * informar la inflacion mas baja junto con el numero de mes
             * informar la inflacion mas alta junto con el numero de mes
             * informar el promedio de inflacion
             * */

            double[] vec = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
            double total = 0;
            double masBajo = 100;
            int mes = 0;
            double masAlto = 0;
            int mes2 = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                total += vec[i];

                if (masBajo > vec[i])
                {
                    masBajo = vec[i];
                    mes = i;
                }
                if (masAlto < vec[i])
                {
                    masAlto = vec[i];
                    mes2 = i;
                }

            }
            Console.WriteLine("El total de inflacion anual es : " + total);
            Console.WriteLine("\n El mes con menos inflacion es el mes : {0} con una inflacion de {1}", (mes + 1), masBajo);
            Console.WriteLine("\n El mes con mas inflacion es el mes : {0} con una inflacion de {1}", (mes2 + 1), masAlto);
            Console.WriteLine("\n El promedio de inflacion mensual es : "+(total/12));
        }

        static void ejercicio3()
        {
            /*Agregar los cambios que resulten nesesarios al ejercicio anterior
             * para que en los puntos b y c se informe en vez del numero de mes 
             * el nombre
             * */


            double[] vec = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
            string[] meses = {"ENERO","FEBRERO","MARZO","ABRIL","MAYO","JUNIO","JULIO","AGOSTO","SEPTIEMBRE",
            "OCTUBRE","NOVIEMBRE","DICIEMBRE"};
            double total = 0;
            double masBajo = 100;
            int mes = 0;
            double masAlto = 0;
            int mes2 = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                total += vec[i];

                if (masBajo > vec[i])
                {
                    masBajo = vec[i];
                    mes = i;
                }
                if (masAlto < vec[i])
                {
                    masAlto = vec[i];
                    mes2 = i;
                }

            }
            Console.WriteLine("El total de inflacion anual es : " + total);
            Console.WriteLine("\n El mes con menos inflacion es el mes : {0} con una inflacion de {1}", meses[mes], masBajo);
            Console.WriteLine("\n El mes con mas inflacion es el mes : {0} con una inflacion de {1}",meses[mes2], masAlto);
            Console.WriteLine("\n El promedio de inflacion mensual es : " + (total / 12));
        }

        

    

    static void Main(string[] args)
        {
            ejercicio3();
            //ejercicio1();
            Console.ReadKey();
        }
    }
}
