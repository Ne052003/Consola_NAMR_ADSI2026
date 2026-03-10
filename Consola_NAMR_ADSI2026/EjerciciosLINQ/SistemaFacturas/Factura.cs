using Consola_NAMR_ADSI2026.EjercicioListas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.EjerciciosLINQ.SistemaFacturas
{
    internal class Factura
    {
        internal int Id { get; set; }
        internal int NumeroFactura { get; set; }
        internal Cliente Cliente { get; set; }
        internal decimal Total { get; set; }
        internal bool Pagada { get; set; }




    }
}
