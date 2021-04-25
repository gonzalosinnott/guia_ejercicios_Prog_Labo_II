using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class QuesoAzul : Ingrediente
    {
        /// <summary>
        /// Atributo de la clase
        /// </summary>
        private Procedencia procedencia;
        /// <summary>
        /// Cosntructores de la clase
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        public QuesoAzul(string descripcion, int cantidad) : base(descripcion,cantidad)
        {

        }
        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia) : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }
        /// <summary>
        /// Tipo anidado de Procedencia
        /// </summary>
        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }
        /// <summary>
        /// Getter Proceso
        /// </summary>
        public override string Proceso
        {
            get { return "desgranar"; }
        }
        /// <summary>
        /// Getter UnidadDeMedida
        /// </summary>
        public override string UnidadDeMedida
        {
            get { return "gramos"; }
        }
        /// <summary>
        /// StringBuilder de la clase
        /// </summary>
        /// <returns></returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Informacion());
            sb.AppendLine(String.Format($"Procedente de {procedencia}"));

            return sb.ToString();
        }
    }
}
