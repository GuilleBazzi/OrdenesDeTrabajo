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
    public partial class frmAdmUsuarios : Form
    {
        public frmAdmUsuarios()
        {
            InitializeComponent();
        }

        public static String temporal = "";

        private void frmAdmUsuarios_Load(object sender, EventArgs e)

        {
            Consultar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaUsuario NuevoUsuario = new frmAltaUsuario();
            NuevoUsuario.Show();

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
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_USUARIOS_FILTRO");

                // 3 lleno la grilla

                gvGrilla.DataSource = oTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        private void gvGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmModificarUsuario modificar = new frmModificarUsuario();

            temporal = Convert.ToString(gvGrilla.Rows[gvGrilla.CurrentRow.Index].Cells[0].Value);
            MessageBox.Show(temporal);
            modificar.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdmUsuarios nuevo = new frmAdmUsuarios();
            nuevo.Show();
        }

        private void gvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
