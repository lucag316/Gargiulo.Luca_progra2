using System.Runtime.InteropServices;

internal class Ejercicio_A08
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A08";

        Console.WriteLine("Ingrese la cantidad de empleados: ");
        int cantidadEmpleados = int.Parse(Console.ReadLine());


        for (int i = 1; i <= cantidadEmpleados; i++)
        {
            Console.WriteLine("\nEmpleado {0}: ", i);

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine());

            Console.Write("Ingrese antiguedad(years): ");
            int antiguedad = int.Parse(Console.ReadLine());

            Console.Write("Cantiad de horas trabajadas en el mes: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            double totalBruto = (valorHora * horasTrabajadas) + (antiguedad * 15000);
            double descuento = totalBruto * 0.13;
            double totalNeto = totalBruto - descuento;

            //Console.WriteLine("\nNombre: {0} \nAntiguedad: {1} \nValor hora: {2} \nTotal Bruto: ${3} \nTotal con descuento: ${4} ",nombre, antiguedad, valorHora, totalBruto, totalConDescuento);
            // Mostrar el recibo
            Console.WriteLine("\n***** RECIBO DE SUELDO *****");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Antigüedad: {antiguedad} años");
            Console.WriteLine($"Valor por hora: ${valorHora:F2}");
            Console.WriteLine($"Total a cobrar (bruto): ${totalBruto:F2}");
            Console.WriteLine($"Descuentos (13%): ${descuento:F2}");
            Console.WriteLine($"Valor neto a cobrar: ${totalNeto:F2}");
            Console.WriteLine("*****************************\n");
        }
        Console.ReadLine();
    }
}