using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        #region Constructores

        public Gente(short edad) : base("", edad)
        {

        }

        #endregion

        #region Metodos

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Validar()
        {
            return this.Edad > 18;
        }

        #endregion

    }
}
