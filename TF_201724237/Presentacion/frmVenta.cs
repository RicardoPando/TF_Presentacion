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
    public partial class frmVenta : Form
    {
        public Gestora objform4 { get; set; }
        private Venta objseleccionado;
        public frmVenta()
        {
            InitializeComponent();
        }

        public void Show_clientes()
        {

            objform4.LeerClientesEnRepositorioTXT();
            cmbxDNIventa.DataSource = objform4._listaclientes;
            cmbxDNIventa.DisplayMember = "Nombres";
            cmbxDNIventa.ValueMember = "DNI";

        }
        public void Show_Empresas()
        {
            objform4.LeerEmpresasEnRepositorio();
            cmbxRUCventa.DataSource = objform4._listaempresas;
            cmbxRUCventa.DisplayMember = "RazonSocial";
            cmbxRUCventa.ValueMember = "RUC";
        }
        private bool VerificarDatosCliente()
        {
            return (cmbxDNIventa.SelectedIndex !=-1);
        }
        private bool VerificarDatosEmpresa()
        {
            return (cmbxRUCventa.SelectedIndex !=-1);
        }

        private void btnInsertarVenta_Click(object sender, EventArgs e)
        {
            if (!VerificarDatosCliente() && !VerificarDatosEmpresa())
            {
                Venta r = new Venta();
                r.estado = EstadoUnidad.nuevo;
                string DNI = cmbxDNIventa.SelectedIndex.ToString();
                string RUC = cmbxRUCventa.SelectedIndex.ToString();
                r.CodProducto = cmbxCodigoProducto.SelectedIndex.ToString();
                r.CantidadProductosVentas = txtCantidadVenta.Text;
                r.FechaVenta = dtpkFechaVenta.Value.ToString("dd/MM/yyyy");
                r.FormaDePago = rdbtnEfectivo.Checked ? 'E' : 'T';
                r.ConfirmarEnvio = rdbtnSi.Checked ? 'S' : 'N';

                objform4.InsertarNuevaVenta(r, DNI, RUC);
                objform4.MantenimientoEnRepositorioSQL();

                btnLeerBaseDatos_Click(sender,e);
            }
            else
            {
                MessageBox.Show("Fallo al ingresar Datos");
            }



        }

        private void btnGuardarBaseDatos_Click(object sender, EventArgs e)
        {
            try
            {
                objform4.MantenimientoEnRepositorioSQL();
                MessageBox.Show("Listo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falla");
            }
        }

        private void btnLeerBaseDatos_Click(object sender, EventArgs e)
        {
            objform4.LeerDeRepositorioSQL();
            dtgvVenta.DataSource = null;
            dtgvVenta.DataSource = objform4._listaventas.FindAll(r => r.estado != EstadoUnidad.eliminando);
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (objseleccionado != null)
            {
                objseleccionado.estado = EstadoUnidad.eliminando;
                if (MessageBox.Show("¿Seguro de eliminar esto?","",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    objform4.MantenimientoEnRepositorioSQL();
                }
            }
        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            if (objform4 != null)
            {
                objseleccionado.estado = EstadoUnidad.actualizando;
                objseleccionado.ConfirmarEnvio = rdbtnEfectivo.Checked ? 'E' : 'T';
            }
        }

        private void dtgvVenta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1)
            {
                objseleccionado = objform4._listaventas[e.RowIndex];
                rdbtnEfectivo.Checked = objseleccionado.FormaDePago == 'E';
                rdbtnTarjeta.Checked = objseleccionado.FormaDePago == 'T';
                rdbtnSi.Checked = objseleccionado.ConfirmarEnvio == 'S';
                rdbtnNo.Checked = objseleccionado.ConfirmarEnvio == 'N';
            }
            else
            {
                objseleccionado = null;
            }
        }
    }
}
