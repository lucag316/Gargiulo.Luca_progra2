internal class Ejercicio_A05
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A05";

        Console.Write("Ingrese un número limite para encontrar los centros numericos: ");
        int limite = int.Parse(Console.ReadLine());

        //recorre los numeros desde 1 hasta el limite ingresado por el usuario.
        for (int i = 1; i <= limite; i++)
        {
            if (EsCentroNumerico(i))
            {
                Console.WriteLine($"Centro numerico encontrado: {i}");
            }
        }
        Console.ReadLine();
    }

    static bool EsCentroNumerico(int numero)
    {
        int sumaAntes = 0;
        int sumaDespues = 0;

        // Calcular la suma de los números antes y después del centro numérico
        for (int i = 1; i < numero; i++)
        {
            sumaAntes += i;
        }

        for (int i = numero + 1; ; i++)
        {
            sumaDespues += i;

            if (sumaDespues > sumaAntes) // Detenerse si la suma después es mayor que la suma antes
            {
                break;
            }
            else if (sumaDespues == sumaAntes) // Si las sumas son iguales, es un centro numérico
            {
                return true;
            }
        }
        return false;
    }
}