using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        #region Atributos
        private ConsoleColor color;
        private static int valorHora;
        #endregion

        #region Constructores
        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base (patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }
        #endregion

        #region Metodos
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"Ingreso: {this.ingreso}");
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Color: {this.color}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Automovil;
        }

        public override string ImprimirTicket()
        {
            TimeSpan intervalo = DateTime.Now.Subtract(this.ingreso); 
            int costo = (int)(Math.Round(intervalo.TotalHours) * Automovil.valorHora);
            StringBuilder sb = new StringBuilder();
            sb.Append($"Ticket ");
            sb.Append(this.ConsultarDatos());
            sb.AppendLine($"Value: {costo}");
            sb.AppendLine("-------------------------##");

            return sb.ToString();
        }
        #endregion
    }
}
