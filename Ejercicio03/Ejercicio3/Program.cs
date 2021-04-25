using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por pantalla todos los números primos que haya hasta el número que
            //ingrese el usuario por consola.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

            int numero;

            numero = GetNumero();

            MostrarPrimos(numero);
        }
        static int GetNumero()
        {
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero:");
            } while (int.TryParse(Console.ReadLine(), out numero) != true);

            return numero;
        }
        static void MostrarPrimos(int a)
        {
            int numero = 2;
            int contador;

            Console.WriteLine("Los numeros primos hasta el numero {0} son:", a);
            while (numero <= a)
            {
                contador = 0;
                for (int i = 1; i <= numero; i++)
                {
                    
                    if (numero % i == 0)
                    {
                        contador = contador + 1;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
        }
    }
}
