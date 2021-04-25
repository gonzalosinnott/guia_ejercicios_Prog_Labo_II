using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        #region Atributos

        private int kilosAlimento;
        private string nombre;

        #endregion

        #region Constructores

        public Animal(string nombre, int volumen)
        {
            this.nombre = nombre;
            this.kilosAlimento = volumen;
        }
        #endregion

        #region Propiedades

        public abstract bool ComeBalanceado
        {
            get;
        }

        public abstract bool ComePasto
        {
            get;
        }

        public int KilosAlimento
        {
            get { return kilosAlimento; }
        }
        #endregion

        #region Metodos

        public virtual string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format($"{this.nombre} come {this.kilosAlimento} kg de alimento"));
            
            if(this.ComeBalanceado == true)
            {
                sb.AppendLine("Consume balanceado SI");
            }
            else
            {
                sb.AppendLine("Consume balanceado NO");
            }

            if (this.ComePasto== true)
            {
                sb.AppendLine("Consume pasto SI");
            }
            else
            {
                sb.AppendLine("Consume pasto NO");
            }

            return sb.ToString();

        }

        #endregion
    }
}
