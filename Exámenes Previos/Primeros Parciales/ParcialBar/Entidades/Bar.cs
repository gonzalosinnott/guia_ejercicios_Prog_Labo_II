using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        #region Atributos

        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        #endregion

        #region Cosntructores

        static Bar()
        {
            Bar.singleton = new Bar();
        }

        public Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }

        public Bar GetBar()
        {
            if (Bar.singleton is null)
            {
                Bar.singleton = new Bar();
            }

            return Bar.singleton;
        }

        #endregion

        #region Propiedades

        public List<Empleado> Empleados
        {
            get => this.empleados;
        }

        public List<Gente> Gente
        {
            get => this.gente;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empleado empleado in this.empleados)
            {
                sb.AppendLine(empleado.ToString());
            }

            foreach (Gente gente in this.gente)
            {
                sb.AppendLine(gente.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region Operadores

        public static bool operator +(Bar bar, Empleado empleado)
        {
            if((bar is null) != false && (empleado is null) != false)
            {
                foreach (Empleado empBar in bar.empleados)
                {
                    if(empBar != empleado)
                    {
                        bar.empleados.Add(empleado);
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            if((bar is null) != false && (gente is null) != false)
            {
                foreach (Gente genBar in bar.gente)
                {
                    if(bar.gente.Count < (bar.empleados.Count * 10) && genBar != gente)
                    {
                        bar.gente.Add(gente);
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion    
    }
}
