using ConsoleApp1;

class Program
{
    public static void Main(string[] args)
    {
        Persona persona = new Persona("Juan", 21);
        Console.WriteLine(persona.Nombre);
        Console.WriteLine(persona.Edad);

        persona.Nombre = "David";
        persona.Edad = 24;

        Console.WriteLine(persona.Nombre);
        Console.WriteLine(persona.Edad);

    }
}
