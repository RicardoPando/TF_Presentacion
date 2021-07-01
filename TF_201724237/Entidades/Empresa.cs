using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string DireccionEmpresa { get; set; }
        public string TelefonoEmpresa {get;set;}

        public override string ToString()
        {
            return RUC;
        }
    }
}
