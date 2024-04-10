internal class Ejercicio_A03
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A03";

        int numeroIngresado;

        Console.Write("Ingrese un numero: ");
        while (!int.TryParse(Console.ReadLine(), out numeroIngresado) || numeroIngresado <= 1)
        {
            Console.Write("Ingrese un numero valido: ");
        }
        Console.WriteLine("Numeros primos hasta {0}:", numeroIngresado);

        for (int i = 2; i <= numeroIngresado; i++)
        {
            if (EsPrimo(i))
            {
                Console.Write(i + " ");
            }
            
        }
        Console.ReadLine();
    }

    static bool EsPrimo(int numero)
    {
        if (numero  <= 1)
        {
            return false;
        }
        for (int i = 2; i  * i < numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}