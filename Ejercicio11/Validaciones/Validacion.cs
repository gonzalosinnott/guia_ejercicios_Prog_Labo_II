using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class Validacion
    {
        public void GetMensaje(string a)
        {
            Console.WriteLine(a);
        }
        public void GetMensaje(string a, double b)
        {
            Console.WriteLine(a,b);
        }
        public bool Validar(int valor, int max, int min)
        {
            if(valor < min || valor > max)
            {
                GetMensaje("Ingrese un numero dentro del rango (-100 / 100)");
                return false;
            }
            else
            {
                return true;
            }
        }      

        public int GetInt(string a)
        {
            int b;
            
            do
            {
                GetMensaje(a);
            } while (int.TryParse(Console.ReadLine(), out b) != true);
            
            return b;
        }

        public void GetMaximo(int[] a)
        {
            int max = a[0];

            foreach (int numero in a)
            {
                if (numero > max)
                {
                    max = numero;
                }
            }

            GetMensaje("Maximo: {0}", max);
        }

        public void GetMinimo(int[] a)
        {
            int min = a[0];

            foreach (int numero in a)
            {
                if (numero < min)
                {
                    min = numero;
                }
            }

            GetMensaje("Minimo: {0}", min);
        }
        public void GetPromedio(int[] a)
        {
            int contador = 0;
            int acumulador = 0;
            double promedio;

            foreach (int numero in a)
            {
                contador++;
                acumulador = acumulador + numero;
            }

            promedio = (double)acumulador / contador;

            GetMensaje("Promedio: {0}",promedio);
        }

    }
}
