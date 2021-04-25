using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campo
    {
        #region Atributos

        private int alimentoDisponible;
        private List<Animal> animales;
        private static Tipo servicio;

        public enum Tipo
        {
            Pastoreo,
            Engorde
        }

        #endregion

        #region Cosntructores

        static Campo()
        {
            servicio = Tipo.Engorde;
        }

        private Campo()
        {
            animales = new List<Animal>();
        }

        public Campo(int alimento) : this()
        {
            this.alimentoDisponible = alimento;
        }

        #endregion

        #region Propiedades

        public Tipo TipoServicio
        {
            set { Campo.servicio = value; }
        }

        #endregion

       #region Metodos

        private int AlimentoComprometido()
        {
            int alimentoComprometido = 0;

            foreach (Animal animal in animales)
            {
                alimentoComprometido = alimentoComprometido + animal.KilosAlimento;
            }

            return alimentoComprometido;
        }

        private int AlimentoComprometido(Animal animal)
        {
            return AlimentoComprometido() + animal.KilosAlimento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format($"Servicio del campo {servicio}"));
            sb.AppendLine(String.Format($"Alimento comprometido {AlimentoComprometido()} de {alimentoDisponible}"));
            foreach (Animal animal in this.animales)
            {
                sb.AppendLine(animal.Datos());
            }

            return sb.ToString();
        }
        #endregion

        #region Operadores

        public static bool operator +(Campo campo, Animal animal)
        {
            if ((campo is null) != true && (animal is null) != true)
            {
                if (campo.AlimentoComprometido(animal) <= campo.alimentoDisponible)
                {
                    campo.animales.Add(animal);
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
