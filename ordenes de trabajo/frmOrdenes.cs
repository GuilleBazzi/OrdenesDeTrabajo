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
    public partial class frmOrdenes : Form
    {
        public frmOrdenes()
        {
            InitializeComponent();
        }

        public static string temporal = "";// guarda el id de la orden para usarlo luego en el formulario de modificar
        private string Activos = "Si";// guarda el valor del parametro para obtener sectores activos o borrados

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            Consultar();
        }

            private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaOrden nuevaOrden = new frmAltaOrden();
            nuevaOrden.ShowDialog();
            Consultar();
        }
        private void Consultar()
        {
            //declarar la variable tabla
            DataTable oTabla = new DataTable();

            // establecer la conexion
            Conexion oConexion = new Conexion();

            // ejecutar SP
            try
            {
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Filtro", txtFiltro.Text);
                oConexion.AgregarParametro("@Activo", Activos);
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_ORDENES_FILTRO");

                //lleno la grilla
                gvGrilla.DataSource = oTabla;
                //Cierro conexion
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }

        //Si escribo en el txt filtro ejecuta consultar
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        //Cuando hago click en un elemento en la grilla
        private void gvGrilla_Click(object sender, EventArgs e)
        {
            //llama al fromulario modificar, guarda el id de la orden en la variable para usarla luego en el otro form
            frmModificarOrden nuevo = new frmModificarOrden();
            temporal = Convert.ToString(gvGrilla.Rows[gvGrilla.CurrentRow.Index].Cells[0].Value);
            nuevo.ShowDialog();
            Consultar();
        }

        //Si orpimo actualizar ejecuto consultar
        private void btnAct_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        //Si selecciono obtener inactivos cambio el valor de la variable a No, esta se pasa como parametro al sp
        private void chkInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInactivos.Checked)
            {
                Activos = "No";
                Consultar();
            }
            else
            {
                Activos = "Si";
                Consultar();
            }
        }
    }
}
