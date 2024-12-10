using ConsoleApp3;

class Program
{
    public static void Main(string[] args)
    { 
        
        List<List<int>> matriz = new List<List<int>>();

        Console.WriteLine("Ingresa los elementos de la matriz (3x3):");
        for (int i = 0; i < 3; i++)
        {
            List<int> fila = new List<int>();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i}][{j}]: ");
                int valor = int.Parse(Console.ReadLine());
                fila.Add(valor);
            }
            matriz.Add(fila);
        }

        DiferenciaMatriz result = new DiferenciaMatriz();
        int prueba = result.Diferencia(matriz);

        Console.WriteLine("\nMatriz ingresada:");
        foreach (var fila in matriz)
        {
            Console.WriteLine(string.Join(" ", fila));
        }
        Console.WriteLine($"\nLa suma de los elementos en la diagonal principal es: {prueba}");
    }
}

