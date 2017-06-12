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
    public partial class frmAdmSectores : Form
    {
        public frmAdmSectores()
        {
            InitializeComponent();
        }

        public static string temporal = ""; // guarda el id del sector para usarlo luego en el formulario de modificar
        private string Activos = "Si";  // guarda el valor del parametro para obtener sectores activos o borrados

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // llama al frm nuevo sector
            frmAltaSector nuevoSec = new frmAltaSector();
            nuevoSec.ShowDialog();
            Consultar();
        }


        //al cargar el formulario se ejecuta Consultar
        private void frmAdmSectores_Load(object sender, EventArgs e)
        {
            Consultar();

        }

        private void Consultar()
        {
            //declarar la variable tabla
            DataTable oTabla = new DataTable();

            //establecer la conexion
            Conexion oConexion = new Conexion();
            
            try
            {
                //Listo los sectores
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Filtro", txtFiltro.Text);
                oConexion.AgregarParametro("@Activo", Activos);
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_SECTORES_FILTRO");

                //lleno la grilla
                gvGrilla.DataSource = oTabla;

                //cierro conexion
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }

        //Si escribo en el txt filtro ejecuta consultar
        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            Consultar();
        }


        //Cuando hago click en un elemento en la grilla
        private void gvGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //llama al fromulario modificar sector, guarda el id del sector en la variable para usarla luego en el otro form
            frmModificarSector modificar = new frmModificarSector();
            temporal = Convert.ToString(gvGrilla.Rows[gvGrilla.CurrentRow.Index].Cells[0].Value);
            modificar.ShowDialog();
            Consultar();
        }

        //Si orpimo actualizar ejecuto consultar
        private void btnActualizar_Click(object sender, EventArgs e)
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
