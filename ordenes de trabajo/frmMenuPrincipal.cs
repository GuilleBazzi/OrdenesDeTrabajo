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
            if (frmLogin.TipoUser == 1 || frmLogin.TipoUser == 3) {
                btnSectores.Enabled = false;
                btnSectores.BackColor = Color.Salmon;
                btnPersonal.Enabled = false;
                btnPersonal.BackColor = Color.Salmon;
            }
                ;
            Consultar();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            frmOrdenes adminOrdenes = new frmOrdenes();
            adminOrdenes.ShowDialog();
            Consultar();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            frmAdmUsuarios adminPers = new frmAdmUsuarios();
            adminPers.ShowDialog();
            Consultar();
        }

        private void btnSectores_Click(object sender, EventArgs e)
        {
            frmAdmSectores adminSec = new frmAdmSectores();
            adminSec.ShowDialog();
            Consultar();
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Consultar()
        {
            try
            {
                DataTable oTabla = new DataTable();

                Conexion oConexion = new Conexion();

                oConexion.AgregarParametro("@parametro", "Pendiente");
                oTabla = oConexion.EjecutarQuery("SP_ACTUALIZAR_PRINCIPAL");
                lblPendientes.Text = oTabla.Rows[0]["Cantidad"].ToString();
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@parametro", "En curso");
                oTabla = oConexion.EjecutarQuery("SP_ACTUALIZAR_PRINCIPAL");
                lblCurso.Text = oTabla.Rows[0]["Cantidad"].ToString();
                oConexion.BorrarParametros();

                oConexion.AgregarParametro("@parametro", "Sin asignar");
                oTabla = oConexion.EjecutarQuery("SP_ACTUALIZAR_PRINCIPAL");
                lblSinAsig.Text = oTabla.Rows[0]["Cantidad"].ToString();
                //Cierro conexion
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!! " + ex);

            }
        }

        //Boton actualizar
        private void btnAct_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
