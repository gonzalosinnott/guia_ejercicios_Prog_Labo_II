using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos

        private short edad;
        private string nombre;

        #endregion

        #region Constructores
        protected Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        #endregion

        #region Propiedades
        public short Edad
        {
            get
            {
                return this.edad;
            }
            set 
            {
                if(value > 0)
                {
                    this.edad = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(string.IsNullOrEmpty(value) != false)
                {
                    this.nombre = value;
                }
            }
        }


        #endregion

        #region Metodos

        public static explicit operator string(Persona persona)
        {
            return persona.Mostrar();
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo {this.GetType().Name}");
            
            if(String.IsNullOrEmpty(this.nombre) != false)
            {
                sb.AppendLine($"Nombre: {this.nombre}");
            }

            if(String.IsNullOrEmpty(this.Nombre) != false)
            {
                sb.AppendLine($"Edad: {this.Edad}");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public abstract bool Validar();
        

        #endregion
    }
}
