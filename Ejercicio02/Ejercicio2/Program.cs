using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        //Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
        //Se debe validar que el número sea mayor que cero, caso contrario,
        //mostrar el mensaje: "ERROR. ¡Reingresar número!".
        //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.

        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;

            do
            {
                numero = GetNumero();
            } while (ValidarNumero(numero) != "SUCCESS");

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado de {0} es {1}", numero, cuadrado);
            Console.WriteLine("El cubo de {0} es {1}",numero, cubo);
        }

        static double GetNumero()
        {
            int numero;
           
            do
            {
                Console.WriteLine("Ingrese un numero");
            } while(int.TryParse(Console.ReadLine(),out numero)!=true);

            return (double)numero;
        }

        static string ValidarNumero(double a)
        {
            string result;

            if(a > 0)
            {
                result = "SUCCESS";
            }
            else
            {
                Console.WriteLine("ERROR, REINGRESE UN NUMERO MAYOR A 0");
                result = "ERROR";
            }

            return result;
        }
    }
}
