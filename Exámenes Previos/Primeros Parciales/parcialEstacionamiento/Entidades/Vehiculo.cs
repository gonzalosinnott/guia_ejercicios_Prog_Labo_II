using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region Atributos

        protected DateTime ingreso;
        private string patente;

        #endregion

        #region Cosntructores
        public Vehiculo(string patente)
        {
            this.patente = patente;
            ingreso = DateTime.Now.AddHours(-3);
        }
        #endregion

        #region Propiedades
        public string Patente
        {
            get { return patente; }
            set
            {
                if (string.IsNullOrEmpty(value) != false && value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }
        #endregion

            #region Metodos
        public abstract string ConsultarDatos();
        
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine(String.Format($"Hora de ingreso {ingreso}"));

            return sb.ToString();

        }

        public override string ToString()
        {
            return String.Format($"Patente {patente}");
        }
        #endregion

        #region Operadores

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.Equals(v2) && v2.Equals(v1) && v1.Patente == v2.Patente)
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}
