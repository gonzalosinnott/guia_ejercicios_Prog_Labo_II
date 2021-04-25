using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
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
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(new String(' ', a - i - 1) + new String('*', i + i + 1));
            }
        }
    }
}
