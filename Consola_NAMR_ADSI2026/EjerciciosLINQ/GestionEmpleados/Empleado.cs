using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.EjerciciosLINQ.GestionEmpleados
{
    internal class Empleado
    {
        internal long Id { get; set; }
        internal string Name { get; set; }
        internal string Department { get; set; }
        internal decimal Salary { get; set; }
        internal bool Active { get; set; }

    }
}
