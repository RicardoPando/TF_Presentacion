using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Security.AccessControl;

namespace Negocios
{
    public class Gestora
    {

        public List<Cliente> _listaclientes { get; set; }
        public List<Venta> _listaventas { get; set; }
        public List<Empresa> _listaempresas { get; set; }
        public List<Proveedor> _listaproveedores { get; set; }



        public Gestora()
        {
            _listaclientes = new List<Cliente>();
            _listaempresas = new List<Empresa>();
            _listaproveedores = new List<Proveedor>();
            _listaventas = new List<Venta>();
        }

        public bool VerificaExisteClienteDNI(string consultaDNI)
        {
            return _listaclientes.Exists(c => c.DNI.Equals(consultaDNI));
        }
        public bool VerificaExisteEmpresaRUC(string consultaRUC)
        {
            return _listaempresas.Exists(e => e.RUC.Equals(consultaRUC));
        }
        public bool VerificaExisteProveedorRUC(string consultaRUCP)
        {
            return _listaproveedores.Exists(p => p.RUCproveedor.Equals(consultaRUCP));
        }

        public bool InsertarCliente(Cliente nuevo)
        {
            bool resultado = VerificaExisteClienteDNI(nuevo.DNI);
            if (!resultado)
            {
                _listaclientes.Add(nuevo);
            }

            return !resultado;
        }

        public bool InsertarEmpresa(Empresa nuevo1)
        {
            bool resultado = VerificaExisteEmpresaRUC(nuevo1.RUC);
            if (!resultado)
            {
                _listaempresas.Add(nuevo1);
            }
            return !resultado;
        }
        public bool InsertarProveedor(Proveedor nuevo2)
        {

            bool resultado = VerificaExisteProveedorRUC(nuevo2.RUCproveedor);
            if (!resultado)
            {
                _listaproveedores.Add(nuevo2);
            }

            return !resultado;

        }
        public void GrabarClientesEnRepositorioTXT()
        {
            try
            {
                AccesoDatos.RepositorioTXT repo = new AccesoDatos.RepositorioTXT();
                repo.GrabarClientes_enRepositorioTXT(_listaclientes);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LeerClientesEnRepositorioTXT()
        {
            try
            {
                AccesoDatos.RepositorioTXT repo = new AccesoDatos.RepositorioTXT();
                _listaclientes = repo.LeerClientes_enRepositorioTXT();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void GrabarEmpresasEnRepositorioTXT()
        {
            try
            {
                AccesoDatos.RepositorioTXT repo = new AccesoDatos.RepositorioTXT();
                repo.GrabarEmpresa_enRepositorioTXT(_listaempresas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void LeerEmpresasEnRepositorio()
        {
            try
            {
                AccesoDatos.RepositorioTXT repo = new AccesoDatos.RepositorioTXT();
                _listaempresas = repo.LeerEmpresa_enRepositorioTXT();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void GrabarProveedoresEnRepositorio()
        {
            try
            {
                AccesoDatos.RepositorioTXT repo = new AccesoDatos.RepositorioTXT();
                repo.GrabarProveedor_enRepositorioTXT(_listaproveedores);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void LeerProveedoresEnRepositorioTXT()
        {
            try
            {
                AccesoDatos.RepositorioTXT repo = new AccesoDatos.RepositorioTXT();
                _listaproveedores = repo.LeerProveedor_enRepositorioTXT();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void LeerDeRepositorioSQL()
        {
            try
            {
                AccesoDatos.RepositorioSQL repo = new AccesoDatos.RepositorioSQL();
                _listaventas = repo.Leer_deRepositorioSQL();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void MantenimientoEnRepositorioSQL()
        {
            try
            {
                AccesoDatos.RepositorioSQL repo = new AccesoDatos.RepositorioSQL();
                repo.Insertar_enRepositorioSQL(_listaventas);
                repo.Actualizar_enRepositorioSQL(_listaventas);
                repo.Eliminar_enRepositorioSQL(_listaventas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void InsertarNuevaVenta(Venta nuevo, string dato,string dato2)
        {
            LeerClientesEnRepositorioTXT();
            nuevo.Dato = _listaclientes.Find(c=>c.DNI.Equals(dato));
            _listaventas.Add(nuevo);

            LeerEmpresasEnRepositorio();
            nuevo.Dato2 = _listaempresas.Find(e=>e.RUC.Equals(dato2));
            _listaventas.Add(nuevo);

        }


    }
}
