using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        #region Atributos
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;
        #endregion

        #region Cosntructores

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region Operadores

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {e.nombre}");
            sb.AppendLine($"Espacio disponible: {e.espacioDisponible}");
            sb.AppendLine($"Lista de vehiculos:");
            sb.AppendLine("___________________");
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.Append(item.ConsultarDatos());
                sb.AppendLine("___________________");
            }

            return sb.ToString();
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (!(estacionamiento is null) && !(vehiculo is null))
            {
                foreach (Vehiculo item in estacionamiento.vehiculos)
                {
                    if (item == vehiculo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo)
            {
                if (estacionamiento.vehiculos.Count < estacionamiento.espacioDisponible)
                {
                    estacionamiento.vehiculos.Add(vehiculo);
                }
            }

            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                return vehiculo.ImprimirTicket();
            }

            return "El vehículo no es parte del estacionamiento";
        }


        #endregion
    }
}
