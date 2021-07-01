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
    public partial class frmEmpresa : Form
    {
        public Gestora objform2 { get; set; }
        public frmEmpresa()
        {
            InitializeComponent();
            objform2 = new Gestora();
        }

        private void btnInsertarEmpresa_Click(object sender, EventArgs e)
        {
            Empresa nuevo = new Empresa();
            nuevo.RazonSocial = txtRazonSocial.Text;
            nuevo.RUC = txtRUCempresa.Text;
            nuevo.DireccionEmpresa = txtDireccionEmpresa.Text;
            nuevo.TelefonoEmpresa = txtTelefonoEmpresa.Text;


            if (objform2.InsertarEmpresa(nuevo))
            {
                MessageBox.Show("Listo");
            }
            else
            {
                MessageBox.Show("Falla al insertar valores");
            }
        }

        private void btnGrabarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                objform2.GrabarEmpresasEnRepositorioTXT();
                MessageBox.Show("Listo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla");
            }
        }

        private void btnLeerEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                objform2.LeerClientesEnRepositorioTXT();
                MessageBox.Show("Listo");
                dtgvEmpresa.DataSource = null;
                dtgvEmpresa.DataSource = objform2._listaempresas;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla");
            }
        }
    }
}
