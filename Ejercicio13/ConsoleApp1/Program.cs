using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            int respuesta;
            int numeroConvertidoUno;
            string numeroConvertidoDos;

            Conversor conversor = new Conversor();

            do
            {
                Console.WriteLine("Ingrese un numero");
            }while(double.TryParse(Console.ReadLine(), out numero)!=true);

            do
            {
                Console.WriteLine("Elegir:\n 1-Convertir a Binario\n 2-OCnvertir a decimal");

            }while(int.TryParse(Console.ReadLine(), out respuesta)!= true);

            switch(respuesta)
            {
                case 1:
                    numeroConvertidoUno = conversor.BinarioDecimal(numero.ToString());
                    Console.WriteLine(numeroConvertidoUno);
                    break;
                case 2:
                    numeroConvertidoDos = conversor.DecimalBinario(((int)numero));
                    Console.WriteLine(numeroConvertidoDos);
                    break;
            }
        }
    }
}
