using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.EjercicioListas
{

    internal class Cliente
    {

        public Cliente(string name)
        {
            this.Name = name;
        }
        internal string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


}
