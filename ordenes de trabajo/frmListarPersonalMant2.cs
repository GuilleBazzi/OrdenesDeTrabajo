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
    public partial class frmListarPersonalMant2 : Form
    {
        public frmListarPersonalMant2()
        {
            InitializeComponent();
        }

        private void frmListarPersonalMant2_Load(object sender, EventArgs e)
        {
            //declarar la variable tabla
            DataTable oTabla = new DataTable();

            // establecer la conexion
            Conexion oConexion = new Conexion();
            oConexion.BorrarParametros();
            oTabla = oConexion.EjecutarQuery("SP_LISTAR_PERSONAL_MANT");
            gvGrilla.DataSource = oTabla;
            //Cierro conexion
            oConexion.Desconectar();
        }

        //Cuando oprimo seleccionar toma el que está marcado en la grilla
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                int idOrden = frmModificarOrden.idOrden; //Toma el id de la orden del otro formulario
                //Toma el id del usuario seleccionado en la grilla
                string seleccionado = Convert.ToString(gvGrilla.Rows[gvGrilla.CurrentRow.Index].Cells[0].Value);
                int selec = Convert.ToInt32(seleccionado);
                Conexion oConexion = new Conexion();
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@idO", idOrden);
                oConexion.AgregarParametro("@idP", seleccionado);
                oConexion.EjecutarQuery("SP_ORDEN_PERSONAL");
                MessageBox.Show("Agregado");
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
