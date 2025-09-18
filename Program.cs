using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz (impar): ");
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[N, N];

        // Llenar matriz con i+j
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = i + j;
            }
        }

        // Mostrar matriz completa
        Console.WriteLine("\nMATRIZ COMPLETA");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j].ToString().PadLeft(3));
            }
            Console.WriteLine();
        }

        // Mostrar reloj de arena
        Console.WriteLine("\nRELOJ DE ARENA");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                // Condición del reloj de arena
                if (j >= i && j < N - i || j <= i && j >= N - 1 - i)
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(3));
                }
                else
                {
                    Console.Write("   "); // Espacios vacíos
                }
            }
            Console.WriteLine();
        }
    }
}