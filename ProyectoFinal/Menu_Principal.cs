using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu_Principal : Form
    {
        Venta_de_tickets.Punto_de_venta punto_De_Venta = new Venta_de_tickets.Punto_de_venta();
        MenuStrip.Cartelera Cartelera = new MenuStrip.Cartelera();
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartelera.Show();
            this.Enabled = false;
        }

        private void ventaDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            punto_De_Venta.Show();
            this.Enabled = false;
        }
    }
}
