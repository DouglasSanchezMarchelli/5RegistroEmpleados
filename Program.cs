using System;

namespace RegistroEmpleados
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public decimal SalarioPorHora { get; set; }
        public int HorasTrabajadas { get; set; }

        public decimal CalcularSalario()
        {
            return SalarioPorHora * HorasTrabajadas;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int CANTIDAD_EMPLEADOS = 2;
            Empleado[] empleados = new Empleado[CANTIDAD_EMPLEADOS];

            for (int i = 0; i < CANTIDAD_EMPLEADOS; i++)
            {
                Console.WriteLine($"Ingrese los datos del empleado {i + 1}:");
                empleados[i] = new Empleado();

                Console.Write("Nombre: ");
                empleados[i].Nombre = Console.ReadLine();

                Console.Write("DUI: ");
                empleados[i].DUI = Console.ReadLine();

                Console.Write("NIT: ");
                empleados[i].NIT = Console.ReadLine();

                Console.Write("Salario por Hora: ");
                empleados[i].SalarioPorHora = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Horas trabajadas: ");
                empleados[i].HorasTrabajadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\nRegistro de empleados:");
            Console.WriteLine("|     Nombre     |  DUI| NIT |salario/hora|Horas/Laboradas| Salario  | ");
            Console.WriteLine("--------------------------------------------------------------------");

            decimal totalPlanilla = 0;

            foreach (Empleado empleado in empleados)
            {
                decimal salario = empleado.CalcularSalario();
                totalPlanilla += salario;

                Console.WriteLine($"| {empleado.Nombre,-15}|{empleado.DUI,-5}|{empleado.NIT,-5}|{empleado.SalarioPorHora,-15}|{empleado.HorasTrabajadas,-15}|{salario,-10:C} |");
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"Total de planilla: {totalPlanilla:C}");
        }
    }
}
