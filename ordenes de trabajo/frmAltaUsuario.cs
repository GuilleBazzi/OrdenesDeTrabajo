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
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frmAltaPersona_Load(object sender, EventArgs e)
        {
            //Creo conexion
            Conexion objConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");
            cmbSector.DataSource = objConexion.EjecutarQuery("SP_LISTAR_SECTORES"); //Ejecuto sp
            cmbSector.DisplayMember = "Nombre"; //Elijo el campo a mostrar


            cmbTipoDesuario.DataSource = objConexion.EjecutarQuery("SP_LISTAR_TIPO_USUARIO");
            cmbTipoDesuario.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable oTabla = new DataTable();

                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");
                cmbSector.DisplayMember = "IdSector";
                cmbTipoDesuario.DisplayMember = "IdTipo";

                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Nombre", txtNombre.Text);  //agrego los parametros al sp con los datos tomados ce los txt y cmb
                oConexion.AgregarParametro("@Apellido", txtApe.Text);
                oConexion.AgregarParametro("@Email", txtEmail.Text);
                oConexion.AgregarParametro("@Alias", txtAlias.Text);
                oConexion.AgregarParametro("@Clave", txtClave.Text);
                oConexion.AgregarParametro("@TipoUsuario", cmbTipoDesuario.Text);
                oConexion.AgregarParametro("@Sector", cmbSector.Text);
                oTabla = oConexion.EjecutarQuery("SP_ALTA_USUARIO");

                this.Hide();
                MessageBox.Show("Usuario creado");
                oConexion.Desconectar();
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }
    }
}
