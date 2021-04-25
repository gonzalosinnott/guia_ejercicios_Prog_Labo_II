using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        #region Atributos

        private bool corredor;

        #endregion

        #region Constructores

        public Caballo(string nombre, int kilosAlimento, bool corredor) :base(nombre,kilosAlimento)
        {
            this.corredor = corredor;
        }

        #endregion

        #region Propiedades

        public override bool ComeBalanceado
        {
            get { return false; }
        }

        public override bool ComePasto
        {
            get { return true; }
        }

        #endregion

        #region Metodos

        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(base.Datos());

            if(this.corredor == true)
            {
                sb.AppendLine("Es de carreras SI");
            }
            else
            {
                sb.AppendLine("Es de carreras NO");
            }

            return sb.ToString();
        }

        #endregion
    }
}
