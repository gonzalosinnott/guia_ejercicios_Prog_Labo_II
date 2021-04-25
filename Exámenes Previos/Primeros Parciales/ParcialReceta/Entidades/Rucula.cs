using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rucula : Ingrediente
    {
        /// <summary>
        /// COsntructor de la clase
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        public Rucula(string descripcion, int cantidad) :base(descripcion,cantidad)
        {

        }
        /// <summary>
        /// Getter Proceso
        /// </summary>
        public override string Proceso
        {
            get { return "cortar"; }
        }
        /// <summary>
        /// Getter UnidadDeMedida
        /// </summary>
        public override string UnidadDeMedida
        {
            get { return "hojas"; }
        }
    }
}
