internal class Ejercicio_A04
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A04";

        int numero = 2;
        int cantidadPerfectosEncontrados = 0;
        

        while (cantidadPerfectosEncontrados < 4)
        {
            int sumaDivisores = 1;

            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }
            if (sumaDivisores == numero)
            {
                Console.WriteLine($"Numero perfecto encontrado: {numero}" );
                cantidadPerfectosEncontrados++;
            }
            numero++;
        }
        Console.ReadLine();
    }
}