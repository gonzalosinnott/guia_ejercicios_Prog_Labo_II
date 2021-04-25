using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banano : Planta
    {
        /// <summary>
        /// Atributo respecifico de Banano
        /// </summary>
        private string codigo;
        /// <summary>
        /// Cosntructor de Banano
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        /// <param name="codigo"></param>
        public Banano(string nombre, int tamanio, string codigo): base(nombre,tamanio)
        {
            this.codigo = codigo;
        }
        /// <summary>
        /// Getter TieneFlores. En el caso de Banano inicializa en true.
        /// </summary>
        public override bool TieneFlores
        {
            get { return true; }
        }
        /// <summary>
        /// Getter TieneFruto. En el caso de banano inicializa en True
        /// </summary>
        public override bool TieneFruto
        {
            get { return true; }
        }
        /// <summary>
        /// Imprime en pantalla ela informacion de cada Banano
        /// </summary>
        /// <returns></returns>
        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine(String.Format("Código internacional: {0}",this.codigo));

            return sb.ToString();
        }
    }
}
