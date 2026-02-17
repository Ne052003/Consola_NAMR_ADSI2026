using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.EjerciciosCiclos
{
    internal class Tienda
    {
        internal void Start()
        {
            bool correctInput = false;
            double grossTotal = 0;
            double discount = 0;
            double netTotal = 0;
            while (!correctInput)
            {

                Console.Write("¿Cuántos productos va a comprar?: ");
                if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                {
                    for (int i = 1; i <= cantidad; i++)
                    {
                        correctInput = false;
                        while (!correctInput)
                        {

                            Console.WriteLine($"Por favor ingresa el precio del producto {i}");
                            if (int.TryParse(Console.ReadLine(), out int precio) && precio > 0)
                            {
                                grossTotal += precio;
                                correctInput = true;
                            }
                            else
                            {
                                Console.WriteLine("Precio no válido\n");
                            }
                        }
                    }

                    //Calcular descuento
                    if (grossTotal >= 500)
                    {
                        discount = grossTotal * 0.20;
                        netTotal = grossTotal - discount;
                    }
                    else if (grossTotal >= 200)
                    {
                        discount = grossTotal * 0.10;
                        netTotal = grossTotal - discount;
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa una cantidad de productos válida\n");
                }
            }

            Console.WriteLine($"\nTotal bruto: {grossTotal}$");
            Console.WriteLine($"Descuento: {discount}$");
            Console.WriteLine($"Total neto: {netTotal}$");
        }
    }
}
