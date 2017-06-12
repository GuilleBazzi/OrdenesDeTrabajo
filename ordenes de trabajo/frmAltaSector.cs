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
    public partial class frmAltaSector : Form
    {
        public frmAltaSector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //comprueba que los campos no esten vacios
                if (txtDesc.Text != "" && txtNombre.Text != "") { 
                    DataTable oTabla = new DataTable();

                    // establecer la conexion
                    Conexion oConexion = new Conexion();

                    oConexion.BorrarParametros();
                    oConexion.AgregarParametro("@Nombre", txtNombre.Text);  //agrego los parametros al sp con los datos tomados ce los txt y cmb
                    oConexion.AgregarParametro("@Descripcion", txtDesc.Text);
                    oTabla = oConexion.EjecutarQuery("SP_NUEVO_SECTOR");
                    MessageBox.Show("Sector creado");
                    this.Hide(); 
                    //Cierro conexion
                    oConexion.Desconectar();

                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void frmAltaSector_Load(object sender, EventArgs e)
        {

        }
    }
}
