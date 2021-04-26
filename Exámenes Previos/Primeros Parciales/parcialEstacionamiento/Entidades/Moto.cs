using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributos

        private int cilindrada;
        private short ruedas;
        private static int valorHora;
        #endregion

        #region Cosntructores

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada)
            : base(patente)
        {
            this.ruedas = 2;
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas)
            : this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora)
            : this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }
        #endregion

        #region Metodos

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"Ingreso: {this.ingreso}");
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Cilindradas: {this.cilindrada}");
            sb.AppendLine($"Ruedas: {this.ruedas}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Moto;
        }

        public override string ImprimirTicket()
        {
            TimeSpan intervalo = DateTime.Now.Subtract(this.ingreso);
            int costo = (int)(Math.Round(intervalo.TotalHours) * Moto.valorHora);
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
