using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta : EntidadesBase
    {
        public Cliente Dato { get; set; }
        public Empresa Dato2 { get; set; }
        public string CodProducto { get; set; }
        public string CantidadProductosVentas { get; set; }
        public string FechaVenta { get; set; }
        public char FormaDePago { get; set; }
        public char ConfirmarEnvio { get; set; }



    }
}
