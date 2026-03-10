using Consola_NAMR_ADSI2026.EjercicioListas;

namespace Consola_NAMR_ADSI2026.EjerciciosLINQ.SistemaFacturas
{
    internal class SistemaFacturas
    {

        internal static void Run()
        {
            bool running = true;
            var facturas = ObtenerFacturas();

            while (running)
            {
                ShowMenu();
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            MostrarFacturas(facturas);
                            break;

                        case 2:
                            {
                                MostrarFacturasNoPagasMasTotalPendiente(facturas);
                                break;
                            }
                        case 3:
                            {
                                MostrarFacturasOrdenadasPorTotalDescendente(facturas);
                                break;
                            }
                        case 4:
                            {
                                MostrarFacturasCaras(facturas);
                                break;
                            }
                        case 5:
                            {
                                MostrarFacturas(facturas);
                                MostrarFacturasNoPagasMasTotalPendiente(facturas);
                                MostrarFacturasOrdenadasPorTotalDescendente(facturas);
                                MostrarFacturasCaras(facturas);
                                break;
                            }
                        case 6:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Por favor ingresa una opción válida");
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Por favor ingresa una opción correcta\n");
                }
            }
        }

        public static List<Factura> ObtenerFacturas()
        {

            Random random = new();
            List<Factura> facturas = [];

            for (int i = 1; i <= 10; i++)
            {
                Factura factura = new()
                {
                    Id = i,
                    Cliente = new Cliente("Pepito" + i),
                    NumeroFactura = i + random.Next(),
                    Total = ((Decimal)random.NextDouble()) * 2000000,
                    Pagada = random.Next(0, 2) == 1
                };

                facturas.Add(factura);
            }

            return facturas;
        }

        internal static void MostrarFacturasNoPagasMasTotalPendiente(List<Factura> facturas)
        {
            var facturasNoPagas = facturas.Where(x => !x.Pagada).ToList();

            MostrarFacturas(facturasNoPagas);

            decimal totalPorPagar = facturasNoPagas.Sum(x => x.Total);
            Console.WriteLine($"Total por pagar: {totalPorPagar}");
        }

        internal static void MostrarFacturasOrdenadasPorTotalDescendente(List<Factura> facturas)
        {
            var facturasOrdenadas = facturas.OrderByDescending(x => x.Total).ToList();
            MostrarFacturas(facturasOrdenadas);
        }

        internal static void MostrarFacturasCaras(List<Factura> facturas)
        {
            var facturasCaras = facturas.Where(x => x.Total > 1_000_000).ToList();

            if (facturasCaras.Count == 0)
            {
                Console.WriteLine("No hay facturas mayores a un millón");
            }
            else
            {
                MostrarFacturas(facturasCaras);
            }
        }
        static void MostrarFacturas(List<Factura> facturas)
        {
            foreach (var item in facturas)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Número factura: " + item.NumeroFactura);
                Console.WriteLine("Cliente: " + item.Cliente);
                Console.WriteLine("Total: " + item.Total);
                Console.WriteLine("Pagada: " + item.Pagada + "\n");
            }
        }

        internal static void ShowMenu()
        {
            Console.WriteLine("\n----Menú-----");
            Console.WriteLine("1. Mostrar todas las facturas");
            Console.WriteLine("2. Mostrar solo las facturas no pagas y el total por pagar");
            Console.WriteLine("3. Mostrar facturas por valor descendente");
            Console.WriteLine("4. Mostrar facturas mayores a 1.000.000");
            Console.WriteLine("5. Mostrar todo de una vez");
            Console.WriteLine("6. Salir");
        }
    }
}
