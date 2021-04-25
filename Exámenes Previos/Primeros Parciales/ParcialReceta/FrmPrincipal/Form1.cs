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

namespace FrmPrincipal
{
    public partial class frmPrincipal : Form
    {
        public Receta receta;
        /// <summary>
        /// Cosntructor Formulario
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        /// <summary>
        /// Evento para harcodear datos de testeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.receta = new Receta(45);
            bool pudo = this.receta + new Rucula("Eruca sativa", 10);
            pudo = this.receta + new Rucula("Diplotaxis muralis", 15);
            pudo = this.receta + new QuesoAzul("Roquefort", 3,
            QuesoAzul.Procedencia.Francia);
            pudo = this.receta + new QuesoAzul("Clásico", 5);
            pudo = this.receta + new Pera("Dulce", 12, "Williams");
            if (this.receta + new Pera("Seca", 1, "Blanquilla"))
            {
                Console.WriteLine("ERROR!");
            }
        }
        /// <summary>
        /// Evento que muestra los datos en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbSalidaDeTest.Text = this.receta.ToString();
        }
    }
}
