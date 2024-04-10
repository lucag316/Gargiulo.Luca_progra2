internal class Ejercicio_A09
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A09";


        Console.Write("Ingrese la altura de la piramide: ");
        int altura = int.Parse(Console.ReadLine());

        for (int fila = 1; fila <= altura; fila++)
        {
            for (int i = 1; i <= fila * 2 - 1; i++)//cuantos asteriscos imprime en cada fila
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}