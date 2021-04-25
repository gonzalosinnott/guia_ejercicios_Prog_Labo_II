using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respuesta;
            char c;
            double numero;
            double acumulador = 0;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero:");

                }while(double.TryParse(Console.ReadLine(), out numero)!=true);

                acumulador = acumulador + numero;
                do
                {
                    Console.WriteLine("¿Continuar? (S/N)");
                    c = char.Parse(Console.ReadLine());
                }while(c.Equals('S') != true &&
                       c.Equals('N') != true);

                respuesta = ValidaS_N(c);

            } while(respuesta == true);

            Console.WriteLine("La suma de los numeros ingresados es {0}", acumulador);

        }

        static bool ValidaS_N(char c)
        { 
            if(c == 'S')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
