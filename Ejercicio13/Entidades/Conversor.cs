using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {

        public string DecimalBinario(int c)
        {
            if(c > int.MaxValue)
            {
                return "El valor del numero a convertir excede el int.MaxValue";
            }

            int numeroAux = Math.Abs((int)c);

            string binario = "";

            if (numeroAux == 0)
            {
                binario = "0";
            }

            while (numeroAux > 0)
            {
                binario = numeroAux % 2 + binario;
                numeroAux = numeroAux / 2;
            }
            return binario;
        }

        public int BinarioDecimal(string c)
        {           

            int numero = int.Parse(c);
            int residuo = 0;
            int exponente = 0;
            int resultado = 0;

            do
            {
                residuo = numero % 10;
                numero = numero / 10;
                resultado = resultado + (int)(residuo * Math.Pow(2, exponente));
                exponente++;
            } while (numero != 0);

            return resultado;
        }

        private bool EsBinario(string binario)
        {
            bool condicion = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    condicion = false;
                    break;
                }
            }
            return condicion;
        }
    }
}
