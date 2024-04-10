internal class Ejercicio_A07
{
    private static void Main(string[] args)
    {
        // SI PONGO UN DIA DE ESTE AÑO SE PONE -99, CORREGIR
        Console.Title = "Ejercicio Nro A07";

        Console.WriteLine("Ingrese una fecha de nacimiento: ");
        Console.Write("Dia: ");
        int diaNacimiento = int.Parse(Console.ReadLine());

        Console.Write("Mes: ");
        int mesNacimiento = int.Parse(Console.ReadLine());

        Console.Write("year: ");
        int yearNacimiento = int.Parse(Console.ReadLine());

        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;

        //calcular dias vividos
        int diasVividos = CalcularDiasVividos(diaNacimiento, mesNacimiento, yearNacimiento, fechaActual);

        Console.WriteLine($"Ha vivido {diasVividos} dias hasta hoy");

        Console.ReadLine();
    }


    static int CalcularDiasVividos(int diaNacimiento, int mesNacimiento, int yearNacimiento, DateTime fechaActual)
    {
        // Calcular la diferencia de años entre la fecha de nacimiento y la fecha actual
        int diferenciaYears = fechaActual.Year - yearNacimiento;

        // Calcular el número de días vividos en los años completos
        int diasVividos = diferenciaYears * 365;

        // Sumar un día adicional por cada año bisiesto
        for (int year = yearNacimiento; year <= fechaActual.Year; year++)
        {
            if (EsBisiesto(year))
            {
                diasVividos++;
            }
        }
        // Restar los días transcurridos en el año actual pero antes de la fecha actual
        int diasTrascurridosEsteYear = fechaActual.DayOfYear;
        diasVividos -= diasTrascurridosEsteYear;

        // Si el mes de nacimiento es después del mes actual, sumar un año más para corregir
        if (mesNacimiento > fechaActual.Month)
        {
            diasVividos += 365;
            if (EsBisiesto(fechaActual.Year))
            {
                diasVividos++;
            }
        }
        return diasVividos;
    }


    static bool EsBisiesto(int year)
    {
        // Un año es bisiesto si es múltiplo de 4.
        bool esMultiplode4 = year % 4 == 0;

        // Los años múltiplos de 100 no son bisiestos, salvo si también son múltiplos de 400.
        bool noEsMultiploDe100 = year % 100 != 0;
        bool esMultiplode400 = year % 400 == 0;

        bool esBisiesto = (esMultiplode4 && noEsMultiploDe100) || esMultiplode400;

        return esBisiesto;
    }
}