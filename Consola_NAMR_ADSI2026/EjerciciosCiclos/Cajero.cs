using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_NAMR_ADSI2026.EjercicioCajero
{
    internal class Cajero
    {
        private int budget = 1000;

        internal void Start()
        {
            int option = 0;
            while (option != 4)
            {
                ShowMenu();
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    option = input;
                    if (option == 1)
                    {
                        ConsultarSaldo();
                    }
                    else if (option == 2)
                    {
                        bool correctAmount = false;

                        while (!correctAmount)
                        {
                            Console.Write("Ingrese el valor a depositar: ");
                            if (int.TryParse(Console.ReadLine(), out int monto))
                            {
                                budget += monto;
                                correctAmount = true;
                                Console.WriteLine($" Depósito Exitoso.\nNuevo saldo: " + budget + "\n");
                            }
                            else
                            {
                                Console.WriteLine("Por favor ingresa un monto válido. (No negativo ni texto)\n");
                            }
                        }
                    }

                    else if (option == 3)
                    {
                        bool correctInput = false;

                        while (!correctInput)

                        {
                            Console.WriteLine("Ingrese el valor a retirar:");
                            if (int.TryParse(Console.ReadLine(), out int monto))
                            {

                                if (budget - monto < 0)
                                {
                                    Console.WriteLine("ERROR. Fondos insuficientes.\n");
                                }
                                else
                                {
                                    budget -= monto;
                                    correctInput = true;
                                    Console.WriteLine($"Nuevo saldo: " + budget + "\n");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Por favor ingresa un monto válido. (No texto)\n");
                            }
                        }
                    }
                    else if (option == 4)
                    {
                        Console.WriteLine("Gracias por usar el sistema.\nCerrando el programa...\n");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingresa una opción válida\n");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor ingresa una opción válida. (No texto, solo una de las opciones disponibles)\n");
                }
            }
        }

        private void ConsultarSaldo()
        {
            Console.WriteLine(budget);
        }

        private void ShowMenu()
        {
            Console.WriteLine("---- Menú ----");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir\n");
            Console.Write("Opción:");
        }
    }
}
