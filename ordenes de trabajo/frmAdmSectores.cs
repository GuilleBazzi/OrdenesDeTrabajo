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
    public partial class frmAdmSectores : Form
    {
        public frmAdmSectores()
        {
            InitializeComponent();
        }

        public static string temporal = "";

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaSector nuevoSec = new frmAltaSector();
            //this.Hide();
            nuevoSec.Show();
        }



        private void frmAdmSectores_Load(object sender, EventArgs e)
        {
            Consultar();

        }

        private void Consultar()
        {
            //0 declarar la variable tabla
            DataTable oTabla = new DataTable();

            //1 establecer la conexion
            Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");

            // 2 ejecutar spProducto_ConsultarTodos
            try
            {
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Filtro", txtFiltro.Text);
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_SECTORES_FILTRO");

                // 3 lleno la grilla

                gvGrilla.DataSource = oTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            Consultar();
        }

        private void gvGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmModificarSector modificar = new frmModificarSector();

            temporal = Convert.ToString(gvGrilla.Rows[gvGrilla.CurrentRow.Index].Cells[0].Value);
          //  MessageBox.Show(temporal);
            modificar.ShowDialog();
            Consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmAdmSectores nuevo = new frmAdmSectores();
            this.Close();
            nuevo.Show();
        }
    }
}
