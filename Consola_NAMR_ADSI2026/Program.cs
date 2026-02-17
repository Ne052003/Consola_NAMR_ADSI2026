using Consola_NAMR_ADSI2026.Ciclos;
using Consola_NAMR_ADSI2026.EjercicioCajero;
using Consola_NAMR_ADSI2026.EjerciciosCiclos;

namespace Consola_NAMR_ADSI2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Cajero cajero = new Cajero();
             cajero.Start();*/

            ControlTemperatura controlTemperatura = new ControlTemperatura();
            controlTemperatura.Start();

            //Tienda tienda = new Tienda();
            //tienda.Start();
        }

        private static void FakeMain()
        {
            CiclosFor objCiclo = new CiclosFor();

            /*objCiclo.CicloFor();
            objCiclo.ForMultiplicar();*/

            //objCiclo.showMenu();

            List<int> numeros = new List<int>();
            numeros.Add(23);
            numeros.Add(22);
            numeros.Add(27);
            numeros.Add(130);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < numeros.Count(); i++)
            {
                Console.WriteLine(numeros[i]);
            }

            CalcularPromedio5(2, 3, 4, 1, 2); //2
            CalcularPromedio5(3, 7, 9); //6
        }

        private static int CalcularPromedio5(int nota1, int nota2, int nota3, int nota4, int nota5)
        {
            int suma = nota1 + nota2 + nota3 + nota4 + nota5; //Creacíón de la variable dentro del método
            int promedio = suma / 5;

            if (promedio > 4)
            {
                Console.WriteLine($"La suma dió{suma}"); //Uso de la variable dentro de un if que está dentro del método
            }
            return promedio;
        }

        private static int CalcularPromedio5(int nota1, int nota2, int nota3)
        {
            int suma = nota1 + nota2 + nota3;
            int promedio = suma / 3;
            return promedio;
        }


    }

}
