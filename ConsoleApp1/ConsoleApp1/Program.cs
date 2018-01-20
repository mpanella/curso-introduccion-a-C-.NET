using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void trabajo1()
        {
            //dado el siguiente comando 
            //int nro1=100,nro2=500,nro3=250
            //informar cual de los 3 numeros es el mayor


            int nro1 = 100, nro2 = 500, nro3 = 250;
            string mensaje = "";

            if(nro1 > nro2)
            {
                if(nro1 > nro3)
                {
                    mensaje = " El numero mayor es 1";
                }
                else
                {
                    mensaje = "El numero mayor es 3";
                }

            }
            else
            {
                if (nro2 > nro3)
                {
                    mensaje = " el numero mayor es 2";
                }
                else
                {
                    mensaje = " el numero mayor es 3";
                }
            }

            Console.WriteLine(mensaje);
        }

        static void trabajo2()
        {
            //dado el siguiente codigo
            //int a = 10 , b = -2 ,c = 5 //hay dos numeros positivos y uno negativo
            // informar la multiplicacion de los dos positivos

            int a = 10, b = -2, c = 5,resul = 0;
            string mensaje = "";

            if(a < 0)
            {
                resul = b * c;
                mensaje = " b * c ";
            }else
                if( b < 0)
            {
                resul = a * c;
                mensaje = " a * c ";
            }
            else
            {
                resul = a * b;
                mensaje = " a * b ";
            }

            Console.WriteLine(" el resultado de la multiplicacion de " + mensaje + " " + resul);
        }

        static void trabajo3()
        {
            //trabajo 3 
            // dado el siguiente codigo
            //string usuario = "pepito" , clave = "educacionIT"
            // informar los siguientes casos
            //si usuario ="pepito" y clave ="educacionIT" informar = "Bienvenido pepito!"
            //si usuario = "pepito" y clave no es "educacionIT"
            //informar " el usuario no coincide con la contraseña"
            //si el usuario no es "pepito" informar "El usuario no existe!"

            string usuario = "", clave = "";
            string mensaje = "";

            Console.Write(" ingrese usuario ");
            usuario = Console.ReadLine();
            Console.Write(" ingrese contraseña : ");
            clave = Console.ReadLine();

            if(usuario == "pepito")
            {
                if( clave == "educacionIT")
                {
                    mensaje = "bienvenido pepito!";
                }
                else
                {
                    mensaje = "clave incorrecta";
                }
            }
            else
            {
                if(clave != "educacionIT")
                {
                    mensaje = "usuario y contraseña incorrecta";
                }
                else
                {
                    mensaje = " usuario incorrecto";
                }
               
            }

            Console.WriteLine(mensaje);
        }

        static void ejercicio1()
        {
            int n1 = 5, n2 = 10, n3 = 20;


            Console.WriteLine("\n \tlos valores son n1 : " + n1 +" n2 : "+n2+" y n3 : "+n3+"\n" + "\n");

            Console.WriteLine("la suma de n1 y n2 es : " + (n1 + n2) + "\n");
            Console.WriteLine("la resta de n3 y n1 es : " + (n3 - n1) + "\n");
            Console.WriteLine("la multiplicacion de n1 y n3 es : " + (n1 * n3) + "\n");
            Console.WriteLine("la divicion de n3 y n2 es : " + (n3 / n2) + "\n");



        }

        static void ejercicio2()
        {
            int n1 = 10, n2 = 20, n3 = 30;


            Console.WriteLine("\n \tlos valores son n1 : " + n1 + " n2 : " + n2 + " y n3 : " + n3 + "\n" + "\n");

            Console.WriteLine("el total de n1 , n2 y n3 es  : " + (n1 + n2 + n3) + "\n");
            Console.WriteLine("el promedio de n1, n2 y n3 es : " + ( ( n1 + n2 + n3 ) / 3 ) + "\n");
            Console.WriteLine("el resto de n2 y n1 es : " + (n2 % n1) + "\n");
            


        }
        static void Main(string[] args)
        {
            //trabajo1();
            //trabajo2();
            //trabajo3();
            //ejercicio1();
            ejercicio2();
            Console.ReadKey();

        }
    }
}
