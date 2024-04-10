internal class Ejercicio_A01
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A01";
        double numero;
        double suma_numero = 0;
        double maximo = 0;
        double minimo = 0;
        double promedio;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Introduce un numero: " );
            numero = double.Parse(Console.ReadLine());

            if (i == 0)
            {
                maximo = numero;
                minimo = numero;
            }
            if (numero > maximo)
            {
                maximo = numero;
            }
            if (numero < minimo)
            {
                minimo = numero;
            }
            suma_numero += numero;
        }
        promedio = suma_numero / 5;
        Console.WriteLine("El promedio es: {0} - minimo: {1} - maximo: {2}", promedio, minimo, maximo);
        Console.ReadLine();
    }
}