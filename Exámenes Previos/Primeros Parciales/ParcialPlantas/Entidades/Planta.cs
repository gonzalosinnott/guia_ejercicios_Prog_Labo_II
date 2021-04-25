using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        string nombre;
        int tamanio;

        public int Tamanio
        {
            get { return this.tamanio; }
        }

        public abstract bool TieneFlores
        {
            get;
        }

        public abstract bool TieneFruto
        {
            get;
        }

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("{0} tiene un tamaño de {1}", this.nombre, this.tamanio));
            
            if(this.TieneFlores == true)
            {
                sb.AppendLine(String.Format("Tiene flores SI"));
            }
            else
            {
                sb.AppendLine(String.Format("Tiene flores NO"));
            }

            if (this.TieneFruto == true)
            {
                sb.AppendLine(String.Format("Tiene fruto SI"));
            }
            else
            {
                sb.AppendLine(String.Format("Tiene fruto NO"));
            }

            return sb.ToString();
        }


    }
}
