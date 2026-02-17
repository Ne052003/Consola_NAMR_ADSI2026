using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.Ciclos
{
    internal class CiclosFor
    {
        internal void CicloFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Indice: {i}");
            }
        }
        internal void CicloForEach(List<int> listaEnteros)
        {
            foreach (int i in listaEnteros)
            {
                Console.WriteLine(i);
            }
        }

        public void ForMultiplicar()
        {
            bool acceso = true;

            while (acceso)
            {
                Console.WriteLine("Tabla de Multiplicar ");
                Console.WriteLine("1. Tabla de Multiplicar ");
                Console.WriteLine("2. Salir \n");

                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    Console.WriteLine("Por favor digita un número a multiplicar del 1 al 10\n");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine($"{i} x {numero}= {resultado}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dato inválido\n");
                    }
                }
                else if (opt == 2)
                {
                    break;
                }

            }
        }

        public void showMenu()
        {

            bool keepGoing = true;
            do
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1. Ejecutar CicloFor");
                Console.WriteLine("2. Ejecutar For Multiplicar");
                Console.WriteLine("3. Salir\n");

                if (int.TryParse(Console.ReadLine(), out int opt))
                {
                    switch (opt)
                    {
                        case 1:
                            CicloFor();
                            break;
                        case 2:
                            ForMultiplicar();
                            break;
                        case 3:
                            keepGoing = false;
                            Console.WriteLine("Hasta Luego");
                            break;
                        default:
                            Console.WriteLine("Opción no válida\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida, por favor ingrese un número.\n");
                }

            } while (keepGoing);
        }
    }

}