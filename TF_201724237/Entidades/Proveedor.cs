using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        public string RazonSocialProveedor { get; set; }
        public string RUCproveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public string PaisOrigen { get; set; }

        public string TiempoEntrega { get; set; }
        public string CostoMaterial { get; set; }

        public override string ToString()
        {
            return RUCproveedor;
        }
    }
}
