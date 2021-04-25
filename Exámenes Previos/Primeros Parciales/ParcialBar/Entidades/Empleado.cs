using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Atributos

        private int dni;

        #endregion

        #region Cosntructores

        public Empleado(string nombre, short edad) : base(nombre, edad)
        {

        }

        public Empleado(string nombre, short edad, int dni): this(nombre, edad)
        {
            this.dni = dni;
        }

        #endregion

        #region Metodos

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(this.dni != -1)
            {
                sb.AppendLine($"DNI: {this.dni}");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Validar()
        {
            return this.Edad > 21 && this.Nombre.Length > 1;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.Nombre == e2.Nombre && e1.Edad == e2.Edad;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return e1 != e2;
        }

        #endregion

    }
}
