using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pera : Ingrediente
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private string tipo;
        /// <summary>
        /// Cosntructor de la clase
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        /// <param name="tipo"></param>
        public Pera(string descripcion, int cantidad, string tipo) : base(descripcion,cantidad)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Getter Proceso
        /// </summary>
        public override string Proceso
        {
            get { return "cubitar"; }
        }
        /// <summary>
        /// Getter UnidadDeMedida
        /// </summary>
        public override string UnidadDeMedida
        {
            get { return "unidades"; }
        }
        /// <summary>
        /// StringBuilder de la clase
        /// </summary>
        /// <returns></returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Informacion());
            sb.AppendLine(String.Format($"Tipo: {tipo}"));

            return sb.ToString();
        }
    }
}
