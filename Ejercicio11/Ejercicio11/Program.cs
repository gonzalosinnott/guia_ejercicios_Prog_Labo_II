using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Ejercicio11
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int numero;
            int max = 100;
            int min = -100;

            for(int i = 0; i < 10; i++)
            {
                do
                {
                    numero = new Validacion().GetInt("Ingrese un numero");
                } while (new Validacion().Validar(numero, max, min) != true);
                numeros[i] = numero;
            }

            new Validacion().GetMaximo(numeros);
            new Validacion().GetMinimo(numeros);
            new Validacion().GetPromedio(numeros);
        }
    }
}
