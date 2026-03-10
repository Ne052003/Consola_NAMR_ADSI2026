using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.Listas.Modelos
{
    internal class Persona
    {

        Persona()
        {
            name = "NombrePorDefecto";
        }

        internal string name { get; set; }
        internal int edad { get; set; }
        internal string sexo { get; set; } = String.Empty;
        internal bool tieneHijos { get; set; }
    }
}
