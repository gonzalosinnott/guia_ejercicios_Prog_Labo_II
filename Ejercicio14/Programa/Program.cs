using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            double altura;
            double baSe;
            double radio;
            double area;
            
            do
            {
                do
                {
                    Console.WriteLine("Ingrese figura a calcular: \n1-Cuadrado\n2-Triangulo\n3-Circulo");
                    int.TryParse(Console.ReadLine(), out respuesta);
                } while (respuesta < 1 || respuesta > 3);

                switch (respuesta)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese altura");
                        } while (double.TryParse(Console.ReadLine().Replace('.', ','), out altura) != true);
                        area = CalculoDeArea.CalcularCuadrado(altura);
                        Console.WriteLine("El area de un cuadrado de {0} de lado es {1}", altura, area);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Ingrese altura");
                        } while (double.TryParse(Console.ReadLine().Replace('.',','), out altura) != true);
                        do
                        {
                            Console.WriteLine("Ingrese base");
                        } while (double.TryParse(Console.ReadLine().Replace('.', ','), out baSe) != true);
                        area = CalculoDeArea.CalcularTriangulo(baSe, altura);
                        Console.WriteLine("El area de un triangulo de base {0} y altura {1} es {2}", baSe, altura, area);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Ingrese radioa");
                        } while (double.TryParse(Console.ReadLine(), out radio) != true);
                        area = CalculoDeArea.CalcularCirculo(radio);
                        Console.WriteLine("El area de un circulo de radio {0} es {1}", radio, area);
                        break;
                }
            } while (ValidaS_N()!=false);

        }
        static bool ValidaS_N()
        {
            char c;
            do
            {
                Console.WriteLine("¿Hacer otro calculo? (S/N)");
                c = char.Parse(Console.ReadLine());
            
            } while (c.Equals('S') != true &&
                       c.Equals('N') != true);

            if (c == 'S')
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
