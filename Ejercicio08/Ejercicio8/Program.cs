using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float valorHora, anosAntiguedad,
                horasPorMes, totalHoras,
                totalAntiguedad, totalBruto,
                totalDescuento, totalNeto;
            string nombreEmpleado;

            // Mensajes
            Console.Title = "Ejercicio 08";
            Mensaje("Cálculo de sueldo\n" +
                              "-----------------");

            // Ingreso de datos
            valorHora = GetFloat("Ingrese el valor de la hora del empleado: ");
            
            Mensaje("Ingrese nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();
            
            anosAntiguedad = GetFloat("Ingrese antiguedad: ");
            horasPorMes = GetFloat("Ingrese la cantidad de horas trabajadas en el mes: ");

            // Calculo
            totalHoras = valorHora * horasPorMes;
            totalAntiguedad = anosAntiguedad * 150;
            totalBruto = totalHoras + totalAntiguedad;
            totalDescuento = (float)(totalBruto * 1.13) - totalBruto;
            totalNeto = totalBruto - totalDescuento;

            //Mostrar en pantalla
            Console.Clear();
            Console.WriteLine("   Recibo de sueldo:" + "\n" +
                            "   -----------------" + "\n" +
                            "             Nombre: " + nombreEmpleado + "\n" +
                            "         Antiguedad: " + anosAntiguedad + "\n" +
                            "     Valor por hora: " + valorHora + "\n" +
                            " Total sueldo bruto: " + totalBruto + "\n" +
                            "         Descuentos: " + totalDescuento + "\n" +
                            "Valor neto a cobrar: " + totalNeto + "\n");
        }

        static void Mensaje(string a)
        {
            Console.WriteLine(a);
        }

        static float GetFloat(string a)
        {
            float b;
            do
            {
                Mensaje(a);
            }while(float.TryParse(Console.ReadLine(), out b)!= true);

           return b;   
        }
    }
}
