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
    public partial class frmUsuarioMantenimiento : Form
    {
        public frmUsuarioMantenimiento()
        {
            InitializeComponent();
        }



        private void UsuarioMantenimiento_Load(object sender, EventArgs e)
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
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_PERSONAL_MANT");

                // 3 lleno la grilla

                gvGrilla.DataSource = oTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }
    }
}
