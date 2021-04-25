using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        /// <summary>
        /// Atributos especificos de Rosal
        /// </summary>
        Color florColor;
        /// <summary>
        /// Cosntructor Rosal
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Rosal(string nombre, int tamanio) : base(nombre,tamanio)
        {

        }
        /// <summary>
        /// Cosntructor Rosal
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        /// <param name="flor"></param>
        public Rosal(string nombre, int tamanio, Color flor) : this(nombre,tamanio)
        {
            this.florColor = flor;
        }
        /// <summary>
        /// Tipos asociados a la caracteristica Color
        /// </summary>
        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }
        /// <summary>
        /// Getter Tiene flores. EN el caso Rosal inicializa en True
        /// </summary>
        public override bool TieneFlores
        {
            get { return true; }
        }
        /// <summary>
        /// Getter TieneFruto. En el caso Rosal inicializa en False
        /// </summary>
        public override bool TieneFruto
        {
            get { return false; }
        }
        /// <summary>
        /// Imprime en pantalla ela informacion de cada Rosal
        /// </summary>
        /// <returns></returns>
        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine(String.Format("Flores de color:: {0}", this.florColor));

            return sb.ToString();
        }
    }
}
