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
                DataTable oTabla = new DataTable();

                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");

                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Nombre", txtNombre.Text);  //agrego los parametros al sp con los datos tomados ce los txt y cmb
                oConexion.AgregarParametro("@Descripcion", txtDesc.Text);
                oTabla = oConexion.EjecutarQuery("SP_NUEVO_SECTOR");

                this.Hide();
                MessageBox.Show("Sector creado");
                oConexion.Desconectar();




            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }
    }
}
