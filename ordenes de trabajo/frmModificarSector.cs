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
    public partial class frmModificarSector : Form
    {
        public frmModificarSector()
        {
            InitializeComponent();
        }

        private void frmModificarSector_Load(object sender, EventArgs e)
        {
            Consultar();
        }
        private void Consultar()
        {
            int valorId = Convert.ToInt16(frmAdmSectores.temporal);
            //declarar la variable tabla
            DataTable oTabla = new DataTable();

            //establecer la conexion
            Conexion oConexion = new Conexion();

            // ejecutar SP
            try
            {
                oConexion.BorrarParametros();
                oConexion.AgregarParametro("@id", valorId);
                oTabla = oConexion.EjecutarQuery("SP_LISTAR_SECTOR_MODIFICAR");
                lblNombre.Text = oTabla.Rows[0]["Nombre"].ToString();
                txtDesc.Text = oTabla.Rows[0]["Descripcion"].ToString();

                //Cierro conexion
                oConexion.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int valorId = Convert.ToInt16(frmAdmSectores.temporal);            
                DataTable oTabla = new DataTable();
                Conexion oConexion = new Conexion();
                oConexion.AgregarParametro("@id", valorId);
                oConexion.EjecutarQuery("SP_ELIMINAR_SECTOR");
                MessageBox.Show("Sector eliminado");
                this.Hide();
                oConexion.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
               {
                //Comprueba que los campos no esten vacios
                if (txtDesc.Text != "") { 
                    int valorId = Convert.ToInt16(frmAdmSectores.temporal);
                    DataTable oTabla = new DataTable();
                    Conexion oConexion = new Conexion();               
                    oConexion.AgregarParametro("@id", valorId);
                    oConexion.AgregarParametro("@desc", txtDesc.Text);
                    oConexion.EjecutarQuery("SP_MODIFICAR_SECTOR");
                    MessageBox.Show("Sector modificado");
                    this.Hide();
                    oConexion.Desconectar();//desconecta
                }
                else { 
                MessageBox.Show("Debe completar todos los campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!\n\n" + ex.Message);
            }
        }
    
    }
}
