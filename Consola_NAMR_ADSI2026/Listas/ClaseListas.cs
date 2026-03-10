using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.Listas
{
    internal class ClaseListas
    {

        public void obtenerListaPersonas()
        {

            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(new Random().Next());
            }

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            //Clase Producto con nombre, precio y el precio es calculado con Random, creamos un valor aleatorio y lo multiplicamos por el índice
        }
    }
}
