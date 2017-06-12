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
        }

        int CodeOrden = 99; //Guarda el id de la orden 
        DateTime FechaHoy = DateTime.Today;
        string userId = frmLogin.UserId;  //Toma el id del usuario logueado desde el formulario Login



        private void frnOrdenNueva_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            // declarar la variable tabla
            DataTable oTabla = new DataTable();

            // establecer la conexion
            Conexion oConexion = new Conexion();

            //  ejecuto  SP y cargo los datos
           try
            {
                oConexion.AgregarParametro("@id", Convert.ToInt32(userId));
                oTabla = oConexion.EjecutarQuery("SP_USUARIO_CREADOR");
                string Nombre = oTabla.Rows[0]["Nombre"].ToString();
                string Apellido = oTabla.Rows[0]["Apellido"].ToString();
                lblUsuario.Text = Nombre + " " + Apellido;

                oConexion.BorrarParametros();
                oTabla = oConexion.EjecutarQuery("SP_CODIGO_ORDEN");

                string Codigo = oTabla.Rows[0]["id"].ToString();

                CodeOrden = Convert.ToInt32(Codigo);
                CodeOrden += 1;

                lblNumeroOt.Text = "Orden N° " + CodeOrden;
                lblFechaOrden.Text = FechaHoy.ToString("d");
                oConexion.BorrarParametros();
                cmbSector.DataSource = oConexion.EjecutarQuery("SP_LISTAR_SECTORES");
                cmbSector.DisplayMember = "Nombre";
                cmbEstado.DataSource = oConexion.EjecutarQuery("SP_LISTAR_ESTADO");
                cmbEstado.DisplayMember = "Nombre";

                //Cierro conexion
                oConexion.Desconectar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }

        // Al hacer click en guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {       //Comprueba que no esten vacios los campos
                if (txtDescripcion.Text != "" && txtJustificacion.Text != "")
                {

                    DataTable oTabla = new DataTable();

                    //establecer la conexion
                    Conexion oConexion = new Conexion();
                    cmbSector.DisplayMember = "IdSector";
                    cmbEstado.DisplayMember = "IdEstado";

                    oConexion.BorrarParametros();

                    oConexion.AgregarParametro("@Desc", txtDescripcion.Text);  //agrego los parametros al sp con los datos tomados ce los txt y cmb
                    oConexion.AgregarParametro("@FechaCreac", FechaHoy);
                    oConexion.AgregarParametro("@FechaLim", dtpLimite.Text);
                    oConexion.AgregarParametro("@Justif", txtJustificacion.Text);
                    oConexion.AgregarParametro("@Estado", cmbEstado.Text);
                    oConexion.AgregarParametro("@Sector", cmbSector.Text);
                    oConexion.AgregarParametro("@Creador", Convert.ToInt32(userId));
                    oTabla = oConexion.EjecutarQuery("SP_ALTA_ORDEN");

         
                    this.Hide();
                    //cierro conexion
                    oConexion.Desconectar();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos! ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void frmAltaOrden_FormClosing(object sender, FormClosingEventArgs e)
        {
 

        }
    }
}
