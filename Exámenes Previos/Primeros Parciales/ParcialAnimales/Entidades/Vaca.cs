using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vaca : Animal
    {
        #region Atributos

        Clasificacion clasificacion;

        public enum Clasificacion
        {
            Lechera,
            Normando,
            Pasiega,
            HolandoArgentina,
            Tudanca
        }

        #endregion

        #region Cosntructores

        public Vaca(string nombre, int kilosAlimento) : base(nombre,kilosAlimento)
        {

        }

        public Vaca(string nombre, int kilosAlimento, Clasificacion clasificacion) : this(nombre, kilosAlimento)
        {
            this.clasificacion = clasificacion;
        }

        #endregion

        #region Propiedades

        public override bool ComeBalanceado
        {
            get { return true; }
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
            sb.AppendLine(String.Format($"Clasificada como {this.clasificacion}"));

            return sb.ToString();
        }

        #endregion
    }
}
