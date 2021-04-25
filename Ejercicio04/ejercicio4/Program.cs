using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        //Escribir una aplicación que encuentre los 4 primeros números perfectos.
        static void Main(string[] args)
        {
            float suma = 0, resto = 0, contador = 0, i, numero = 0;
            
            while (contador !=5)
            {
                numero++;
                suma = 0;
                for (i = 1; i < numero; i++)
                {
                    resto = numero % i;
                    if (resto == 0)
                    {
                        suma = suma + i;
                    }
                }
                if (suma == numero)
                {
                    Console.WriteLine("numero: {0}", i);
                    contador++;
                }
            }
        }
    }
}
