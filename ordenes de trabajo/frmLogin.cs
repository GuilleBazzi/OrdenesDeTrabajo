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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static String UserAlias ="";  //Variable publica que guarda el id del que inicia sesion para poder usarla en otra ventana

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable oTabla = new DataTable();

                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");


                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Alias", txtUsuario.Text);
                oConexion.AgregarParametro("@Clave", txtContraseña.Text);
                oTabla = oConexion.EjecutarQuery("SP_INICIO_SESION");


                DataRow row = oTabla.Rows[0];

                UserAlias = row[0].ToString();

                if (row[0].ToString() == txtUsuario.Text)
                    {
                       // MessageBox.Show("Se inicio sesion");

                        oConexion.Desconectar();
                        this.Hide();
                        frmMenuPrincipal principal = new frmMenuPrincipal();

                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña invalidos, respete las mayusculas");
                    }
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
