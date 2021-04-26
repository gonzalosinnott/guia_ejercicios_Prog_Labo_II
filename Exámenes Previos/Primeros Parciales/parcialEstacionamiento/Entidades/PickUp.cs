using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        #region Atributos
        private string modelo;
        private static int valorHora;
        #endregion

        #region Constructores

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora)
            : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }
        #endregion

        #region Metodos

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"Ingreso: {this.ingreso}");
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Modelo: {this.modelo}");

            return sb.ToString();
        }

        //TODO: check this
        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }

        public override string ImprimirTicket()
        {
            TimeSpan intervalo = DateTime.Now.Subtract(this.ingreso);
            int costo = (int)(Math.Round(intervalo.TotalHours) * PickUp.valorHora);
            StringBuilder sb = new StringBuilder();
            sb.Append($"Ticket");
            sb.Append(this.ConsultarDatos());
            sb.AppendLine($"Value: {costo}");
            sb.AppendLine("-------------------------##");

            return sb.ToString();
        }
        #endregion

    }
}
