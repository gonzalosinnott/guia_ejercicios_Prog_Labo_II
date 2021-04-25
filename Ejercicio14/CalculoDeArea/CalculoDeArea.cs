using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double altura)
        {
            double area = 0;
            area = altura * altura;
            return area;           
        }
        public static double CalcularTriangulo(double baSe, double altura)
        {
            return (baSe * altura) / 2;
        }
        public static double CalcularCirculo(double radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
    }
}
