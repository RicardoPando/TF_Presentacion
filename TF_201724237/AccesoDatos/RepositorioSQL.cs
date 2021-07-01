using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class RepositorioSQL
    {

        private string cadena_conexion;
        private string Tabla;
        private string comando_leer_datos;
        private string comando_insertar;
        private string comando_actualizar;
        private string comando_borrar;


        public RepositorioSQL()
        {
            cadena_conexion = "data source=. ; Initial Catalog=TF; Integrated Security=true ; ";

            comando_leer_datos = "SELECT[Dato] ,[CodigoProducto],[CantidadProductosVentas],[FechaVenta],[FormaDePago],[ConfirmarEnvioVenta] FROM[dbo].[Venta]";
            comando_insertar = "INSERT INTO[dbo].[Venta] ([Dato],[CodigoProducto],[CantidadProductosVentas],[FechaVenta],[FormaDePago],[ConfirmarEnvioVenta]) VALUES(@Dato, @CodigoProducto, @CantidadProductosVentas, @FechaVenta, @FormaDePago, @ConfirmarEnvioVenta)";
            comando_borrar = "DELETE FROM[dbo].[Venta]  WHERE[Dato] = @Dato AND[FechaVenta] = @FechaVenta";
            comando_actualizar = "UPDATE[dbo].[Venta]  SET[CodigoProducto] = @CodigoProducto ,[CantidadProductosVentas] = @CantidadProductosVentas ,[FormaDePago] = @FormaDePago ,[ConfirmarEnvioVenta] = @ConfirmarEnvioVenta WHERE[Dato] = @Dato AND[FechaVenta] = @FechaVenta";

        }

        public List<Venta> Leer_deRepositorioSQL()
        {
            List<Venta> aux = new List<Venta>();
            List <Cliente> listaclientes = new RepositorioTXT().LeerClientes_enRepositorioTXT();
            List<Empresa> listaEmpresa = new RepositorioTXT().LeerEmpresa_enRepositorioTXT();
            SqlConnection sqlcon = new SqlConnection(cadena_conexion);
            SqlCommand sqlcmd = new SqlCommand(comando_leer_datos, sqlcon);

            try
            {
                sqlcon.Open();
                SqlDataReader dr = sqlcmd.ExecuteReader();

                while (dr.Read())
                {
                    Venta nuevo = new Venta();
                    nuevo.Dato = listaclientes.Find(c=>c.DNI.Equals(Convert.ToString(dr[0]).TrimEnd()));
                    nuevo.Dato2 = listaEmpresa.Find(e => e.RUC.Equals(Convert.ToString(dr[0]).TrimEnd()));
                    nuevo.CodProducto = Convert.ToString(dr[1]);
                    nuevo.CantidadProductosVentas = Convert.ToString(dr[2]);
                    nuevo.FechaVenta = Convert.ToString(dr[3]);
                    nuevo.FormaDePago = Convert.ToChar(dr[4]);
                    nuevo.ConfirmarEnvio = Convert.ToChar(dr[5]);

                    nuevo.estado = EstadoUnidad.antiguo;
                    aux.Add(nuevo);


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }

            return aux;

        }
        public void Insertar_enRepositorioSQL(List<Venta> _listaventas)
        {
            SqlConnection sqlcon = new SqlConnection(cadena_conexion);
            SqlCommand sqlcmd = new SqlCommand(comando_insertar,sqlcon);

            try
            {
                sqlcon.Open();

                foreach (Venta v in _listaventas.FindAll(es => es.estado==EstadoUnidad.nuevo))
                {
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add(new SqlParameter("@Dato", v.Dato.DNI));
                    sqlcmd.Parameters.Add(new SqlParameter("@Dato", v.Dato2.RUC));
                    sqlcmd.Parameters.Add(new SqlParameter("@CodigoProducto", v.CodProducto));
                    sqlcmd.Parameters.Add(new SqlParameter("@CantidadProductosVentas", v.CantidadProductosVentas));
                    sqlcmd.Parameters.Add(new SqlParameter("@FechaVenta", v.FechaVenta));
                    sqlcmd.Parameters.Add(new SqlParameter("@FormaDePago", v.FormaDePago));
                    sqlcmd.Parameters.Add(new SqlParameter("@ConfirmarEnvioVenta", v.ConfirmarEnvio));
                    sqlcmd.CommandType = System.Data.CommandType.Text;
                    sqlcmd.ExecuteNonQuery();


                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }



        }
        public void Actualizar_enRepositorioSQL(List<Venta> _listaventas)
        {
            SqlConnection sqlcon = new SqlConnection(cadena_conexion);
            SqlCommand sqlcmd = new SqlCommand(comando_actualizar, sqlcon);

            try
            {
                sqlcon.Open();

                foreach (Venta v in _listaventas.FindAll(es => es.estado == EstadoUnidad.nuevo))
                {
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add(new SqlParameter("@Dato", v.Dato.DNI));
                    sqlcmd.Parameters.Add(new SqlParameter("@Dato", v.Dato2.RUC));
                    sqlcmd.Parameters.Add(new SqlParameter("@CodigoProducto", v.CodProducto));
                    sqlcmd.Parameters.Add(new SqlParameter("@CantidadProductosVentas", v.CantidadProductosVentas));
                    sqlcmd.Parameters.Add(new SqlParameter("@FechaVenta", v.FechaVenta));
                    sqlcmd.Parameters.Add(new SqlParameter("@FormaDePago", v.FormaDePago));
                    sqlcmd.Parameters.Add(new SqlParameter("@ConfirmarEnvioVenta", v.ConfirmarEnvio));
                    sqlcmd.CommandType = System.Data.CommandType.Text;
                    sqlcmd.ExecuteNonQuery();


                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void Eliminar_enRepositorioSQL(List<Venta> _listaventas)
        {
            SqlConnection sqlcon = new SqlConnection(cadena_conexion);
            SqlCommand sqlcmd = new SqlCommand(comando_borrar, sqlcon);

            try
            {
                sqlcon.Open();

                foreach (Venta v in _listaventas.FindAll(es => es.estado == EstadoUnidad.nuevo))
                {
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add(new SqlParameter("@Dato", v.Dato.DNI));
                    sqlcmd.Parameters.Add(new SqlParameter("@Dato", v.Dato2.RUC));               
                    sqlcmd.Parameters.Add(new SqlParameter("@FechaVenta", v.FechaVenta));
                    sqlcmd.CommandType = System.Data.CommandType.Text;
                    sqlcmd.ExecuteNonQuery();


                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }



        }




    }
}
