using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que pida por pantalla la fecha de nacimiento de una persona
            //(día, mes y año) y calcule el número de días vividos por esa persona hasta la
            //fecha actual(tomar la fecha del sistema con DateTime.Now).
            //Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.

            DateTime nacimiento;
            DateTime hoy;
            TimeSpan diferencia;
            
            Console.Write("Ingrese fecha de nacimiento DD/MM/AA: ");
            nacimiento = DateTime.Parse(Console.ReadLine());
            
            hoy = DateTime.Now;

            diferencia = hoy - nacimiento;
            Console.WriteLine("Los dias de vida vividos son: {0}", diferencia.Days);
        }
    }
}
