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
    public partial class frmModificarOrden : Form
    {
        public frmModificarOrden()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Consultar();
        }


        private void Consultar()
        {
            int valorId = Convert.ToInt16(frmOrdenes.temporal2);
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


                cmbEstado.DataSource = oConexion.EjecutarQuery("SP_LISTAR_ESTADOS");
                cmbEstado.DisplayMember = "Nombre";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            try
            {
                int valorId = Convert.ToInt16(frmOrdenes.temporal2);
                //0 declarar la variable tabla
                DataTable oTabla = new DataTable();

                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");


                oConexion.AgregarParametro("@id", valorId);
                oConexion.EjecutarQuery("SP_ELIMINAR_ORDEN");
                MessageBox.Show("Orden eliminada");
                this.Hide();
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }
        
    }
}
