using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace SI33_Plantilla
{
    public partial class frmProveedor : Form
    {
        public Gestora objform3 { get; set; }
        public frmProveedor()
        {
            InitializeComponent();
            objform3 = new Gestora();
        }

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor nuevo = new Proveedor();
            nuevo.RazonSocialProveedor = txtRazonSocialProveedor.Text;
            nuevo.RUCproveedor = txtRUCproveedor.Text;
            nuevo.DireccionProveedor = txtDireccionProveedor.Text;
            nuevo.CostoMaterial = txtCostoMaterial.Text;
            nuevo.PaisOrigen = cmbxPaisOrigen.SelectedIndex.ToString();
            nuevo.TiempoEntrega = txtTiempoEntrega.Text;
            nuevo.TelefonoProveedor = txtTelefonoProveedor.Text; ;


            if (objform3.InsertarProveedor(nuevo))
            {
                MessageBox.Show("Listo");
            }
            else
            {
                MessageBox.Show("Falla");
            }



        }

        private void btnGrabarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                objform3.GrabarProveedoresEnRepositorio();
                MessageBox.Show("Listo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla"); ;
            }
        }

        private void btnLeerProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                objform3.LeerProveedoresEnRepositorioTXT();
                MessageBox.Show("Listo");
                dtgvProveedor.DataSource = null;
                dtgvProveedor.DataSource = objform3._listaproveedores;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla");
            }
        }
    }
}
