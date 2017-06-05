using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenes_de_trabajo
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            frmOrdenes adminOrdenes = new frmOrdenes();
            adminOrdenes.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
           // this.Hide();
            frmAdmUsuarios adminPers = new frmAdmUsuarios();
            adminPers.Show();
        }

        private void btnSectores_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmAdmSectores adminSec = new frmAdmSectores();
            adminSec.Show();
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
