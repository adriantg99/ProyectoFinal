using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Venta_de_tickets
{
    public partial class Punto_de_venta : Form
    {
        Menu_Principal menu_Principal = new Menu_Principal();
        public Punto_de_venta()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            menu_Principal.Enabled = true;
            this.Close();
            
        }
    }
}
