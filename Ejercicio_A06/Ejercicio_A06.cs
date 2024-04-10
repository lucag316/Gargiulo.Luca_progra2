internal class Ejercicio_A06
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A06";

        Console.Write("Ingrese el year de inicio: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el year de fin: ");
        int fin = int.Parse(Console.ReadLine());

        Console.Write($"Years bisiestos entre {inicio} y {fin}: ");

        for (int year = inicio; year < fin; year++)
        {
            if (EsBisiesto(year))
            {
                Console.Write(year + ", ");
            }
        }
        Console.ReadLine();
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