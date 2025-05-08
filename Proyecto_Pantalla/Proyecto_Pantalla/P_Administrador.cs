using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pantalla
{
    public partial class P_Administrador : Form
    {
        public P_Administrador()
        {
            InitializeComponent();
        }

        private void img_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
