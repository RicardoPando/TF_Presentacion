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

    public partial class frmCliente : Form
    {
        public Gestora objform { get; set; }
        
        public Gestora objGestora { get; set; }
        

        public frmCliente()
        {
            InitializeComponent();
            objGestora = new Gestora();
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();
            nuevo.DNI = txtDNIcliente.Text;
            nuevo.Nombres = txtNombreCliente.Text;
            nuevo.Apellidos = txtApellidoCliente.Text;
            nuevo.Direccion = txtDireccionCliente.Text;
            nuevo.Telefono = txtTelefonoCliente.Text;

            if (objGestora.InsertarCliente(nuevo))
            {
                MessageBox.Show("Listo");
            }
            else
            {
                MessageBox.Show("Falla");
            }
        }

        private void btnGrabarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                objGestora.GrabarClientesEnRepositorioTXT();
                MessageBox.Show("Listo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla al grabar el cliente"); 
            }
        }

        private void btnLeerCliente_Click(object sender, EventArgs e)
        {
            try
            {
                objform.LeerClientesEnRepositorioTXT();
                MessageBox.Show("Listo");
                dtgvCliente.DataSource = null;
                dtgvCliente.DataSource = objGestora._listaclientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla al leer el cliente");
            }
        }
    }
}
