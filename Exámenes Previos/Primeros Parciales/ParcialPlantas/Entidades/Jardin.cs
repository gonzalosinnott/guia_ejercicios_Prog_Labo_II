using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        /// <summary>
        /// Atributos Jardin
        /// </summary>
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        /// <summary>
        /// Tipos asociados al atributo suelo
        /// </summary>
        public enum Tipo
        {
            Terrozo,
            Arenoso
        }
        /// <summary>
        /// Setter suelo
        /// </summary>
        Tipo TipoSuelo
        {
            set { }
        }
        /// <summary>
        /// Calcula el espacio ocupado del Jardin
        /// </summary>
        /// <returns></returns>
        private int EspacioOcupado()
        {
            int espacioTotal = 0;
            foreach (Planta planta in plantas)
            {
                espacioTotal = espacioTotal + planta.Tamanio;
            }

            return espacioTotal;
        }
        /// <summary>
        /// Calcula el espacio ocupado del Jardin mas el tamaño de la ultima planta
        /// </summary>
        /// <param name="planta"></param>
        /// <returns></returns>
        private int EspacioOcupado(Planta planta)
        {
            return EspacioOcupado() + planta.Tamanio;
        }
        /// <summary>
        /// Cosntructor para el tipo de suelo
        /// </summary>
        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }
        /// <summary>
        /// Cosntructor Jardin
        /// </summary>
        private Jardin()
        {
            plantas = new List<Planta>();
        }
        /// <summary>
        /// Cosntructor Espacio Total
        /// </summary>
        /// <param name="espacioTotal"></param>
        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }
        /// <summary>
        /// Operador para agregar plantas en el caso de que haya espacio para agregarlas
        /// </summary>
        /// <param name="jardin"></param>
        /// <param name="planta"></param>
        /// <returns></returns>
        public static bool operator +(Jardin jardin, Planta planta)
        { 
            if(jardin.EspacioOcupado(planta) <=  jardin.espacioTotal)
            {
                jardin.plantas.Add(planta);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Muestra los datos de las plantas del jardin
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Compsicion del jardin: {suelo}");
            sb.AppendLine($"Espacio Ocupado {this.EspacioOcupado()} de {this.espacioTotal}");
            foreach(Planta planta in this.plantas)
            {
                sb.AppendLine(planta.ResumenDeDatos());
            }
            return sb.ToString();
        }






    }
}
