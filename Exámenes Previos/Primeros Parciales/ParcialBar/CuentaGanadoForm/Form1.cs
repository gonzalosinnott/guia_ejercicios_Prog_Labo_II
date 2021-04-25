using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CuentaGanadoForm
{
    public partial class frmCuenta : Form
    {

        decimal cantidadGente;
        decimal cantidadEmpleados;
        Bar bar = new Bar();

        public frmCuenta()
        {
            InitializeComponent();
        }
       

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInforme info = new frmInforme();
            info.Location = this.Location;
            info.Show();
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {
            cantidadGente = nudGente.Value;
            cantidadEmpleados = nudEmpleados.Value;
        }

        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (this.cantidadEmpleados <= nudEmpleados.Value)
            {
                Random random = new Random();
                Empleado empleado = new Empleado("Mozo", (short)random.Next(21, 90));

                if(bar + empleado)
                {
                    nudGente.Value = bar.Empleados.Count;
                    cantidadEmpleados = nudEmpleados.Value;
                }
                else
                {
                    nudEmpleados.Value = bar.Empleados.Count;
                }
            }

        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            decimal numActual = nudGente.Value;

            if(cantidadGente <= numActual)
            {
                Gente gente = new Gente(50);
                if(bar + gente)
                {
                    cantidadGente = numActual;
                }
                else
                {
                    nudGente.Value = bar.Gente.Count;
                }
            }
        }
    }
}
