using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.EjerciciosCiclos
{
    internal class ControlTemperatura
    {
        internal void Start()
        {
            bool correctInput = false;
            int cantidadDias = 0;
            int cantidadDiasFrios = 0, cantidadDiasCalurosos = 0;
            double sumaTemperaturas = 0;

            while (!correctInput)
            {
                Console.Write("¿Cuántos días va a registrar?: ");
                if (int.TryParse(Console.ReadLine(), out int inputDias) && inputDias > 0)
                {
                    cantidadDias = inputDias;

                    for (int i = 1; i <= inputDias; i++)
                    {
                        correctInput = false;
                        while (!correctInput)
                        {
                            Console.WriteLine($"\nPor favor ingresa la temperatura del día {i}. (-10° y 50°)");
                            if (int.TryParse(Console.ReadLine(), out int temperatura) && temperatura >= -10 && temperatura <= 50)
                            {
                                sumaTemperaturas += temperatura;

                                if (temperatura > 30)
                                {
                                    cantidadDiasCalurosos++;
                                }
                                else if (temperatura < 15)
                                {
                                    cantidadDiasFrios++;
                                }
                                correctInput = true;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido. (Temperatura debe ser entre -10° y 50°)\n");
                            }
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Valor inválido. (Número de días debe ser mayor a cero)\n");
                }
            }

            Console.WriteLine($"\nCantidad de días calurosos:{cantidadDiasCalurosos}");
            Console.WriteLine($"Cantidad de días fríos:{cantidadDiasFrios}");
            Console.WriteLine($"Promedio de temperatura:{sumaTemperaturas / cantidadDias}\n");

        }
    }
}
