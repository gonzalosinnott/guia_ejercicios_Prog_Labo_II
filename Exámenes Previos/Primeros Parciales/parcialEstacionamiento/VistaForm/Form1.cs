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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        PickUp dodgeRam;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtModelo.Text) && !String.IsNullOrWhiteSpace(txtPatente.Text) && txtPatente.Text.Length == 6)
            {
                dodgeRam = new PickUp(txtPatente.Text, txtModelo.Text);
                MessageBox.Show($"{dodgeRam.ConsultarDatos()}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
