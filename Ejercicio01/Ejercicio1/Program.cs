using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            int[] numeros;
            numeros = new int[5];
            int max, min;
            double promedio;

            for(int i = 0; i <5; i++)
            {
                Console.WriteLine("Ingrese el numero {0}", i+1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            max = GetMaximo(numeros);
            min = GetMinimo(numeros);
            promedio = getPromedio(numeros);

            Console.WriteLine("El maximo es {0}", max);
            Console.WriteLine("El minimo es {0}", min);
            Console.WriteLine("El promedio es {0}", promedio);


        }

        static int GetMaximo(int[] a)
        {
            int max = a[0];

            foreach(int numero in a)
            {                
                if (numero > max)
                { 
                    max = numero;
                }
            }

            return max;
        }

        static int GetMinimo(int[] a)
        {
            int min = a[0];
            
            foreach (int numero in a)
            {
                if (numero < min)
                {
                    min = numero;
                }
            }

            return min;
        }
        static double getPromedio(int[] a)
        {
            int contador = 0;
            int acumulador = 0;
            double promedio;

            foreach(int numero in a)
            {
                contador++;
                acumulador = acumulador + numero;
            }

            promedio = (double)acumulador / contador;

            return promedio;
        }


    }
}
