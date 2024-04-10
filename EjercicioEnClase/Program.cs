internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int edad = 0, otra, otraMas;
        Int32 altura;
        string nombre;
        float variable = float.Parse("25.99");

        Console.WriteLine("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su altura: ");
        altura = int.Parse(Console.ReadLine());

        Console.WriteLine($"Su nombre es: {nombre}" );
        Console.WriteLine("Su edad es {1} y su altura es de {0} ", altura, edad);

        Console.ReadLine();
    }
}
