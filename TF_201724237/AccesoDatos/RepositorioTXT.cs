using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace AccesoDatos
{
    public class RepositorioTXT
    {
        string file_cliente;
        string file_empresa;
        string file_proveedor;
        string file_venta;


        public RepositorioTXT()
        {
            file_cliente = "Cliente.txt";
            file_empresa = "Empresa.txt";
            file_proveedor = "Proveedor.txt";
            file_venta = "Venta.txt";

        }

        public void GrabarClientes_enRepositorioTXT(List<Cliente> _listaclientes)
        {
            try
            {
                TextWriter tw = new StreamWriter(file_cliente);


                foreach (Cliente p in _listaclientes)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(p.DNI); sb.Append(",");
                    sb.Append(p.Nombres); sb.Append(",");
                    sb.Append(p.Apellidos); sb.Append(",");
                    sb.Append(p.Direccion); sb.Append(",");
                    sb.Append(p.Telefono);

                    tw.WriteLine(sb);
                }
                tw.Flush();
                tw.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }

        }
        public List<Cliente> LeerClientes_enRepositorioTXT()
        {
            List<Cliente> aux = new List<Cliente>();
            List<string> archivo = File.ReadAllLines(file_cliente).ToList();

            try
            {
                foreach (String s in archivo)
                {
                    char[] separador = { ',' };
                    string[] campos = s.Split(separador);
                    Cliente antiguo = new Cliente();
                    antiguo.DNI = campos[0];
                    antiguo.Nombres = campos[1];
                    antiguo.Apellidos = campos[2];
                    antiguo.Direccion = campos[3];
                    antiguo.Telefono = campos[4];
                    aux.Add(antiguo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

            return aux;

        }
        public void GrabarEmpresa_enRepositorioTXT(List<Empresa> _listempresa)
        {

            try
            {
                TextWriter tw1 = new StreamWriter(file_empresa);

                foreach (Empresa e in _listempresa)
                {
                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append(e.RUC); sb1.Append(",");
                    sb1.Append(e.RazonSocial); sb1.Append(",");
                    sb1.Append(e.DireccionEmpresa); sb1.Append(",");
                    sb1.Append(e.TelefonoEmpresa);

                    tw1.WriteLine(sb1);
                }
                tw1.Flush();
                tw1.Close();
            }
            catch (Exception ex1)
            {

                throw ex1;
            }
            finally
            {

            }
        }
        public List<Empresa> LeerEmpresa_enRepositorioTXT()
        {
            List<Empresa> aux1 = new List<Empresa>();
            List<string> archivo1 = File.ReadAllLines(file_empresa).ToList();
            try
            {
                foreach (String s1 in archivo1)
                {
                    char[] separador1 = { ',' };
                    string[] campos1 = s1.Split(separador1);
                    Empresa antiguo1 = new Empresa();
                    antiguo1.RUC = campos1[0];
                    antiguo1.RazonSocial = campos1[1];
                    antiguo1.DireccionEmpresa = campos1[2];
                    antiguo1.TelefonoEmpresa = campos1[3];
                    aux1.Add(antiguo1);
                }
            }
            catch (Exception ex1)
            {

                throw ex1;
            }
            finally
            {

            }
            return aux1;
        }

        public void GrabarProveedor_enRepositorioTXT(List<Proveedor> _listaproveedor)
        {

            try
            {
                TextWriter tw2 = new StreamWriter(file_proveedor);
                foreach (Proveedor p in _listaproveedor)
                {
                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append(p.RUCproveedor); sb2.Append(",");
                    sb2.Append(p.RazonSocialProveedor); sb2.Append(",");
                    sb2.Append(p.DireccionProveedor); sb2.Append(",");
                    sb2.Append(p.TelefonoProveedor); sb2.Append(",");
                    sb2.Append(p.PaisOrigen); sb2.Append(",");
                    sb2.Append(p.TiempoEntrega); sb2.Append(",");
                    sb2.Append(p.CostoMaterial);

                    tw2.WriteLine(sb2);
                }
                tw2.Flush();
                tw2.Close();
            }
            catch (Exception ex2)
            {

                throw ex2;
            }
            finally
            {

            }
        }
        public List<Proveedor> LeerProveedor_enRepositorioTXT()
        {
            List<Proveedor> aux2 = new List<Proveedor>();
            List<string> archivo2 = File.ReadAllLines(file_proveedor).ToList();

            try
            {
                foreach (String p in archivo2)
                {
                    char[] separador2 = { ',' };
                    string[] campos2 = p.Split(separador2);
                    Proveedor antiguo2 = new Proveedor();
                    antiguo2.RUCproveedor = campos2[0];
                    antiguo2.RazonSocialProveedor = campos2[1];
                    antiguo2.DireccionProveedor = campos2[2];
                    antiguo2.TelefonoProveedor = campos2[3];
                    antiguo2.PaisOrigen = campos2[4];
                    antiguo2.TiempoEntrega = campos2[5];
                    antiguo2.CostoMaterial = campos2[6];

                    aux2.Add(antiguo2);
                }
            }
            catch (Exception ex2)
            {

                throw ex2;
            }
            finally
            {

            }

            return aux2;

        }



    }
}
