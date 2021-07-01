using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public override string ToString()
        {
            return DNI;
        }
    }
}
