internal class Ejercicio_A02
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro A02";

        double numero;
        double cuadrado = 0;
        double cubo = 0;

        do
        {
            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());
            if (numero >= 0)
            {
                //cuadrado = numero * numero;
                //cubo = numero * numero * numero;

                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
            }
            else
            {
                Console.WriteLine("ERROR, reingresar numero");
            }
        } while (numero < 0);

        Console.WriteLine($"Cuadrado: {cuadrado} \nCubo: {cubo}");
        Console.ReadLine();
    }
}