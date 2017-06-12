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

        public static int idOrden = 0; //Guardo el id de la orden para usarlo en otro form

        private void frmModificarOrden_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        public void Consultar()
        {
            try {
                idOrden = Convert.ToInt32(frmOrdenes.temporal);
                // declarar la variable tabla
                DataTable oTabla = new DataTable();
                //establecer la conexion
                Conexion oConexion = new Conexion();

                //Ejecutar los SP
                cmbEstado.DataSource = oConexion.EjecutarQuery("SP_LISTAR_ESTADO");
                cmbEstado.DisplayMember = "Nombre";

                oConexion.AgregarParametro("@id", idOrden);
                oTabla=oConexion.EjecutarQuery("SP_LISTAR_ORDEN_MODIFICAR");
                txtDescripcion.Text = oTabla.Rows[0]["Descripcion"].ToString();
                txtJustificacion.Text= oTabla.Rows[0]["Justificacion"].ToString();
                lblFechaOrden.Text = oTabla.Rows[0]["FechaCreacion"].ToString();
                lblNumeroOt.Text = "Orden N° " + oTabla.Rows[0]["IdOrden"].ToString();
                dtpInicio.Text = oTabla.Rows[0]["FechaInicio"].ToString();
                dtpFin.Text= oTabla.Rows[0]["FechaFin"].ToString();
                lblFechalimite.Text= oTabla.Rows[0]["FechaLimite"].ToString();

                String creador = oTabla.Rows[0]["Creador"].ToString();
                String estado = oTabla.Rows[0]["Estado"].ToString();
                String sector = oTabla.Rows[0]["Sector"].ToString();
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@id",estado);
                oTabla= oConexion.EjecutarQuery("SP_ESTADO_ORDEN");
                cmbEstado.Text = oTabla.Rows[0]["Nombre"].ToString();
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@id", sector);
                oTabla = oConexion.EjecutarQuery("SP_SECTOR_ORDEN");
                lblsec.Text = oTabla.Rows[0]["Nombre"].ToString();

                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@idO", idOrden);
                oTabla = oConexion.EjecutarQuery("SP_PERSONAL_ASIGNADO");
                gvGrilla.DataSource = oTabla;

                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@id", creador);
                oTabla = oConexion.EjecutarQuery("SP_USUARIO_CREADOR");
                lblUsuario.Text = oTabla.Rows[0]["Nombre"].ToString() + " " + oTabla.Rows[0]["Apellido"].ToString();

                //Cierro conexion
                oConexion.Desconectar();

                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        //agregar personal
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmListarPersonalMant2 nuevo = new frmListarPersonalMant2();
            nuevo.ShowDialog();
            Consultar();
        }

        private void frmModificarOrden_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        //Al presionar guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cmbEstado.DisplayMember = "IdEstado";//Cambio al id para enviarlo al SP
            //creo conexion
            Conexion oConexion = new Conexion();
            oConexion.AgregarParametro("Id",idOrden);
            oConexion.AgregarParametro("FechaIni",dtpInicio.Text);
            oConexion.AgregarParametro("FechaFin",dtpFin.Text);
            oConexion.AgregarParametro("Estado",cmbEstado.Text);
            oConexion.EjecutarQuery("SP_MODIFICAR_ORDEN");
            //cierro conexion
            oConexion.Desconectar();
            MessageBox.Show("Se han guardado los cambios");
            this.Close();
        }

        //Saca usuarios se la grilla
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try { 
                string usuario = Convert.ToString(gvGrilla.Rows[gvGrilla.CurrentRow.Index].Cells[0].Value);//obtiene seleccionado
                Conexion oConexion = new Conexion();
                oConexion.AgregarParametro("Id", usuario);
                oConexion.EjecutarQuery("SP_QUITAR_PERSONAL");
                oConexion.Desconectar();//desconecta
                Consultar();//actualiza pantalla
            }catch
            {
                MessageBox.Show("No hay usuarios para eliminar");
            }
        }

        //Eliminar orden, en realidad cambia el estado a inactivo
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion oConexion = new Conexion();
            oConexion.AgregarParametro("Id", idOrden);
            oConexion.EjecutarQuery("SP_ELIMINAR_ORDEN");
            oConexion.Desconectar();
            MessageBox.Show("Eliminada");
            this.Close();

        }
    }
}
