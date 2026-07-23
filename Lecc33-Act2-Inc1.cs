internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Erick Ramirez \n" +
           "Grado: IVD - Clave = 24\n" +
           "===INVERTIR GRASE===");
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        string invertir = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
            invertir = invertir + frase[i];
        }

        Console.WriteLine();
        Console.WriteLine("Frase invertida: " + invertir);

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}