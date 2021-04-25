using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;                   

            altura = GetInt("Ingrese altura de la piramide: ");

            Dibujo(altura);
        }

        static void Mensaje(string a)
        {
            Console.WriteLine(a);
        }

        static int GetInt(string a)
        {
            int b;
            do
            {
                Mensaje(a);
            } while (int.TryParse(Console.ReadLine(), out b) != true);

            return b;
        }
        static void Dibujo(int a)
        {
            int incremento = 0;

            while (incremento < a)
            {
                incremento++;
                for (int i = 0; i < incremento; i++)
                {
                    if(i == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("**");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
