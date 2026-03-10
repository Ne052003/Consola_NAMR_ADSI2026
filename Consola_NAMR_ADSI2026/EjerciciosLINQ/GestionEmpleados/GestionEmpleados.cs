

namespace Consola_NAMR_ADSI2026.EjerciciosLINQ.GestionEmpleados
{
    internal class GestionEmpleados
    {

        internal static void Run()
        {
            var empleados = ObtenerEmpleados();
            bool running = true;

            while (running)
            {
                ShowMenu();
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    switch (input)
                    {
                        case 1:
                            {
                                MostrarEmpleados(empleados);
                                break;
                            }
                        case 2:
                            {
                                MostrarEmpleadosActivos(empleados);
                                break;
                            }
                        case 3:
                            {
                                MostrarEmpleadosDeIT(empleados);
                                break;
                            }
                        case 4:
                            {
                                MostrarSalarioPromedio(empleados);
                                break;
                            }
                        case 5:
                            {
                                MostrarEmpleadosConSalarioAlto(empleados);
                                break;
                            }
                        case 6:
                            {
                                MostrarEmpleadosAgrupadosPorDepartamento(empleados);
                                break;
                            }
                        case 7:
                            {
                                running = false;
                                break;
                            }
                        default:
                            Console.WriteLine("Por favor ingresa una opción válida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nPor favor ingresa una opción válida. (Números enteros positivos de acuerdo a las opciones mostradas)\n");
                }
            }
        }

        private static void MostrarEmpleadosAgrupadosPorDepartamento(List<Empleado> empleados)
        {
            var empleadosAgrupadosPorDepartamento = empleados.GroupBy(x => x.Department);
            foreach (var department in empleadosAgrupadosPorDepartamento)
            {
                Console.WriteLine($"\n-----Departamento de {department.Key}-----");
                MostrarEmpleados(department.ToList());
            }
        }

        private static void MostrarEmpleadosConSalarioAlto(List<Empleado> empleados)
        {
            var highPaidEmployees = empleados.Where(x => x.Salary > 5_000_000).ToList();
            MostrarEmpleados(highPaidEmployees);
        }

        private static void MostrarSalarioPromedio(List<Empleado> empleados)
        {
            decimal averageSalary = empleados.Average(x => x.Salary);
            Console.WriteLine($"Salario promedio: {averageSalary}\n");
        }

        private static void MostrarEmpleadosDeIT(List<Empleado> empleados)
        {
            var empleadosIT = empleados.Where(x => x.Department.ToUpper().Equals("IT")).ToList();
            MostrarEmpleados(empleadosIT);
        }

        static internal List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = [];
            List<string> departments = ["Recursos Humanos", "IT", "Finanzas"]
            ;

            Random random = new();

            for (int i = 0; i < 15; i++)
            {
                Empleado empleado = new()
                {
                    Id = random.Next(),
                    Name = "Empleado" + i,
                    Department = departments[random.Next(0, 3)],
                    Salary = (Decimal)random.NextDouble() * 10000000,
                    Active = random.Next(0, 2) == 1
                };

                empleados.Add(empleado);

            }
            return empleados;
        }

        internal static void MostrarEmpleadosActivos(List<Empleado> listaEmpleados)
        {
            var empleadosActivos = listaEmpleados.Where(x => x.Active).ToList();
            MostrarEmpleados(empleadosActivos);
        }

        internal static void MostrarEmpleados(List<Empleado> listaEmpleados)
        {
            foreach (var item in listaEmpleados)
            {
                Console.WriteLine($"\nId: {item.Id}");
                Console.WriteLine($"Nombre: {item.Name}");
                Console.WriteLine($"Departamento: {item.Department}");
                Console.WriteLine($"Salario: {item.Salary}");
                Console.WriteLine($"Activo: {item.Active}\n");
            }
        }
        internal static void ShowMenu()
        {
            Console.WriteLine("\n----Menú-----");
            Console.WriteLine("1. Mostrar todos los empleados");
            Console.WriteLine("2. Mostrar empleados activos");
            Console.WriteLine("3. Mostrar empleados del departamento de IT");
            Console.WriteLine("4. Mostrar salario promedio");
            Console.WriteLine("5. Mostrar cuantos empleados ganan más de 5.000.000");
            Console.WriteLine("6. Agrupar empleados por departamento");
            Console.WriteLine("7. Salir\n");
        }
    }
}
