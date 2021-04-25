using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbusto : Planta
    {
        /// <summary>
        /// Constructor de Arbusto
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Arbusto(string nombre, int tamanio) : base(nombre,tamanio)
        {
           
        }
        /// <summary>
        /// Getter de TieneFlores. En el caso de Arbusto inicializa en False
        /// </summary>
        public override bool TieneFlores
        {
            get { return false; }
        }
        /// <summary>
        /// Getter de TieneFruto. En el caso de Arbusto inicializa en False
        /// </summary>
        public override bool TieneFruto
        {
            get { return false; }
        }
    }
}
