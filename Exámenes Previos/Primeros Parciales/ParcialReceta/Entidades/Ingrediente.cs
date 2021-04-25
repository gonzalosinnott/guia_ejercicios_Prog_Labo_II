using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Ingrediente
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private int cantidad;
        private string descripcion;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        public Ingrediente(string descripcion, int cantidad)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }
        /// <summary>
        /// Getter cantidad
        /// </summary>
        public int Cantidad
        {
            get { return this.cantidad; }
        }
        /// <summary>
        /// Getter Proceso
        /// </summary>
        public abstract string Proceso
        {
            get;
        }
        /// <summary>
        /// Getter unidad de medida
        /// </summary>
        public abstract string UnidadDeMedida
        {
            get;
        }
        /// <summary>
        /// String builder de la clase
        /// </summary>
        /// <returns></returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format($"{descripcion} en una cantidad de {cantidad} {this.UnidadDeMedida}"));
            sb.AppendLine(String.Format($"Procesar {this.Proceso}"));

            return sb.ToString();
        }
    }
}
