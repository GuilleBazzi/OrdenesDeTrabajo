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
    public partial class frmAltaOrden : Form
    {
        public frmAltaOrden()
        {
            InitializeComponent();
            Conexion objConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TPOT;Data Source=.\\SQLEXPRESS");
            cmbSector.DataSource = objConexion.EjecutarQuery("SP_LISTAR_SECTORES"); //Ejecuto sp
            cmbSector.DisplayMember = "Nombre"; //Elijo el campo a mostrar


            cmbEstado.DataSource = objConexion.EjecutarQuery("SP_LISTAR_ESTADOS");
            cmbEstado.DisplayMember = "Nombre";
        }

        public static String temporal1 = "";

        private void frnOrdenNueva_Load(object sender, EventArgs e)
        {
            Consultar();
            lblFechaOrden.Text = DateTime.Now.ToString();
        }

        private void Consultar()
        {
            //0 declarar la variable tabla
            DataTable oTabla = new DataTable();

            //1 establecer la conexion
            Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");

            // 2 ejecutar spProducto_ConsultarTodos
            try
            {
                oConexion.BorrarParametros();
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_PERSONAL_MANT");

                // 3 lleno la grilla

                gvGrilla.DataSource = oTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable oDatos = new DataTable();
                //DataTable oMantenimiento = new DataTable();
                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");
                cmbSector.DisplayMember = "IdSector";
                cmbEstado.DisplayMember = "IdEstado";

                
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@Codigo", txtCodigo.Text);
                oConexion.AgregarParametro("@Descripcion", txtDescripcion.Text);  //agrego los parametros al sp con los datos tomados ce los txt y cmb
                oConexion.AgregarParametro("@FechaCreacion", lblFechaOrden.Text);
                oConexion.AgregarParametro("@FechaLimite", dtpLimite.Text);
                oConexion.AgregarParametro("@Justificacion", txtJustificacion.Text);
                oConexion.AgregarParametro("@FechaInicio", dtpInicio.Text);
                oConexion.AgregarParametro("@FechaFin", dtpFin.Text);
                oConexion.AgregarParametro("@Estado", cmbEstado.Text);
                oConexion.AgregarParametro("@Creador", lblUsuario.Text);
                oConexion.AgregarParametro("@Sector", cmbSector.Text);

               // oConexion.AgregarParametro("@CodigoUsuario", lblUsuario.Text);
                //oConexion.AgregarParametro("@Codigo", txtCodigo.Text);

                oDatos = oConexion.EjecutarQuery("SP_ALTA_ORDEN");
                //oMantenimiento = oConexion.EjecutarQuery("SP_ALTA_MANTENIMIENTO");
                this.Hide();
                MessageBox.Show("Orden creada");
                oConexion.Desconectar();




            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

            try
            {
                
                DataTable oMantenimiento = new DataTable();
                //1 establecer la conexion
                Conexion oConexion = new Conexion("Data Source=.\\SQLEXPRESS;Initial Catalog=TPOT;Integrated Security=SSPI;Persist Security Info=False;");
               
                oConexion.BorrarParametros();
               oConexion.AgregarParametro("@CodigoUsuario", lblUsuario.Text);
                oConexion.AgregarParametro("@Codigo", txtCodigo.Text);

                oMantenimiento = oConexion.EjecutarQuery("SP_ALTA_USUARIO_MANTENIMIENTO");
                this.Hide();
                MessageBox.Show("Datos Empleado de Mantenimiento guardados ");
                oConexion.Desconectar();




            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void gvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUsuarioMantenimiento nuevo = new frmUsuarioMantenimiento();

            temporal1 = Convert.ToString(gvGrilla.Rows[gvGrilla.CurrentRow.Index].Cells[0].Value);
            MessageBox.Show(temporal1);
            nuevo.Show();
        }

    }
}
