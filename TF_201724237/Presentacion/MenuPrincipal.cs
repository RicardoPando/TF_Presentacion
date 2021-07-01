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

namespace SI33_Plantilla
{
    public partial class MenuPrincipal : Form
    {
        public Gestora objGestora { get; set; }
        Gestora objprincipal;
        public MenuPrincipal()
        {
            InitializeComponent();
            objprincipal = new Gestora();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.objform = objprincipal;
            frm.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.objform2 = objprincipal;
            frm.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.objform3 = objprincipal;
            frm.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.objform4 = objprincipal;
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.objform5 = objprincipal;
            frm.Show();
        }
    }
}
