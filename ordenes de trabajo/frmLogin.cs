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

        public static String UserId ="";  //Variable publica que guarda el id del que inicia sesion para poder usarla en otra ventana

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // tabla para guardar los datos
                DataTable oTabla = new DataTable();

                // establecer la conexion
                Conexion oConexion = new Conexion();

                // borro parametros, agrego nuevos y ejecuto el SP
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Alias", txtUsuario.Text);
                oConexion.AgregarParametro("@Clave", txtContraseña.Text);
                oTabla = oConexion.EjecutarQuery("SP_INICIO_SESION");

                try
                {
                    
                    UserId = oTabla.Rows[0]["IdUsuario"].ToString();// accedo a la tabla y guardo el id del usuario

                
                    if (oTabla.Rows[0]["Alias"].ToString() == txtUsuario.Text) // Si el alias que me trajo el sp es igual al del textbox
                        {
                           
                            oConexion.Desconectar();  //cierro conexion e ingreso a la aplicacion
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
