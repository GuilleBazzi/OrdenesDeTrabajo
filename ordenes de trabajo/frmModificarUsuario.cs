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
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            Consultar();

        }

        private void Consultar()
        {
            int valorId = Convert.ToInt16(frmAdmUsuarios.temporal);
            //0 declarar la variable tabla
            DataTable oTabla = new DataTable();

            //1 establecer la conexion
            Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");

            // 2 ejecutar spProducto_ConsultarTodos
            try
            {
                oConexion.BorrarParametros();

                cmbSector.DataSource = oConexion.EjecutarQuery("SP_LISTAR_SECTORES"); //Ejecuto sp
                cmbSector.DisplayMember = "Nombre"; //Elijo el campo a mostrar


                cmbTipoDesuario.DataSource = oConexion.EjecutarQuery("SP_LISTAR_TIPO_USUARIO");
                cmbTipoDesuario.DisplayMember = "Nombre";

                oConexion.AgregarParametro("@id", valorId);
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_USUARIOS_MODIFICAR");

                txtEmail.Text = oTabla.Rows[0]["Email"].ToString();
                lblNombre.Text = oTabla.Rows[0]["Nombre"].ToString();
                lblApellido.Text = oTabla.Rows[0]["Apellido"].ToString();
              //  cmbSector.Text = oTabla.Rows[0]["Sector"].ToString();
               // cmbTipoDesuario.Text= oTabla.Rows[0]["Tipo de usuario"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            try
            {
                int valorId = Convert.ToInt16(frmAdmUsuarios.temporal);
                //0 declarar la variable tabla
                DataTable oTabla = new DataTable();

                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");


                oConexion.AgregarParametro("@id", valorId);
                oConexion.EjecutarQuery("SP_ELIMINAR_USUARIO");
                MessageBox.Show("Usuario eliminado");
                this.Hide();
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            try
            {
                int valorId = Convert.ToInt16(frmAdmUsuarios.temporal);
                //0 declarar la variable tabla
                DataTable oTabla = new DataTable();

                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");
                cmbSector.DisplayMember = "IdSector";
                cmbTipoDesuario.DisplayMember = "IdTipo";

                oConexion.AgregarParametro("@id", valorId);
                oConexion.AgregarParametro("@email", txtEmail.Text);
                oConexion.AgregarParametro("@sector", cmbSector.Text);
                oConexion.AgregarParametro("@tipoUsuario", cmbTipoDesuario.Text);
                oConexion.EjecutarQuery("SP_MODIFICAR_USUARIO");
                MessageBox.Show("Usuario modificado");
                this.Hide();
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
