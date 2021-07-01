using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EstadoUnidad { antiguo, nuevo, actualizando, eliminando }
    public class EntidadesBase
    {
        public EstadoUnidad estado { get; set; }

    }
}
