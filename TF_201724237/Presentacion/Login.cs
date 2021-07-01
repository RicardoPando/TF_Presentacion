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
    public partial class Login : Form
    {
        Gestora objGestoraprincipal;
        public Login()
        {
            InitializeComponent();
            objGestoraprincipal = new Gestora();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "u201724237" && txtContraseña.Text == "1721")
            {
                MenuPrincipal frm = new MenuPrincipal();
                frm.objGestora = objGestoraprincipal;
                frm.Show();
                //////////////////////////
                txtCodigo.Text = "";
                txtContraseña.Text = "";
            }
            else if (txtCodigo.Text == "u20172423" && txtContraseña.Text == "172")
            {
                MenuPrincipal frm = new MenuPrincipal();
                frm.objGestora = objGestoraprincipal;
                frm.Show();
                //////////////////////////
                txtCodigo.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Datos Incorrectos - Acceso Denegado");
                txtCodigo.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}
