using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Receta
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;
        /// <summary>
        /// Constructores
        /// </summary>
        static Receta()
        {
            preparacion = Tipo.Clasica;
        }

        private Receta()
        {
            ingredientes = new List<Ingrediente>();
        }
        
        public Receta(int capacidad) : this()
        {
            this.capacidadDelContenedor = capacidad;
        }
        /// <summary>
        /// Tipos anidados de preparacion
        /// </summary>
        public enum Tipo
        {
            Clasica,
            Especial
        }
        /// <summary>
        /// Setter tipo de preparacion
        /// </summary>
        Tipo TipoDePreparacion
        {
            set { }
        }
        /// <summary>
        /// Calcula la capacidad libre del contenedor
        /// </summary>
        /// <returns></returns>
        private int CapacidadLibre()
        {
            int espacioLibre = capacidadDelContenedor;
            
            foreach (Ingrediente ingrediente in ingredientes)
            {
                espacioLibre = espacioLibre - ingrediente.Cantidad;
            }

            return espacioLibre;

        }
        /// <summary>
        /// Clacula la capcidad libre del contenedor al agregarle un ingrediente
        /// </summary>
        /// <param name="ingrediente"></param>
        /// <returns></returns>
        private int CapacidadLibre(Ingrediente ingrediente)
        {
            return CapacidadLibre() - ingrediente.Cantidad;

        }
        /// <summary>
        /// Agrega un ingrediente a la receta en caso de que haya espacio
        /// </summary>
        /// <param name="receta"></param>
        /// <param name="ingrediente"></param>
        /// <returns></returns>
        public static bool operator +(Receta receta, Ingrediente ingrediente)
        {
            if(receta.CapacidadLibre(ingrediente) <= receta.capacidadDelContenedor)
            {
                receta.ingredientes.Add(ingrediente);
                return true;
            }

            return false;
        }        
        /// <summary>
        /// Sobrecarga de ToString() que muestra los datos de la receta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format($"Receta: {preparacion}"));
            sb.AppendLine(String.Format($"Capacidad Libre {CapacidadLibre()}"));
            sb.AppendLine(String.Format($"Capacidad Total {capacidadDelContenedor}"));
            foreach (Ingrediente ingrediente in this.ingredientes)
            {
                sb.AppendLine(ingrediente.Informacion());
            }
            return sb.ToString();
        }

    }
}
