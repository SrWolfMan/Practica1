using System;

class Programa
{
    static void Main()
    {
        // le pedimos al usuario 5 números enteros:
        Console.WriteLine("por favor, ingrese 5 números enteros:");
        // declaramos un vector con los números que le pedimos al usuario
        int[] vector = new int[5];

        for (int i = 0; i < vector.Length; i++){
            Console.WriteLine($"ingrese el número {i+1}:");
            vector[i] = int.Parse(Console.ReadLine()??"");
        }

        Console.WriteLine();

        // Mostrar el array original
        Console.WriteLine("Vector original:");
        foreach (int numero in vector)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        // Implementación del método de selección para ordenar el array
        int n = vector.Length;

        // Recorremos todo el array
        for (int i = 0; i < n - 1; i++)
        {
            // Buscamos el índice del elemento más pequeño en la parte no ordenada
            int minIndex = i;

            // Buscamos el valor mínimo en el resto del array (de i+1 a n-1)
            for (int j = i + 1; j < n; j++)
            {
                if (vector[j] < vector[minIndex])
                {
                    minIndex = j; // Actualizamos el índice del mínimo
                }
            }

            // Intercambiamos el valor encontrado con el primer valor no ordenado
            if (minIndex != i)
            {
                int temp = vector[i];
                vector[i] = vector[minIndex];
                vector[minIndex] = temp;
            }
        }

        // Mostrar el array ordenado
        Console.WriteLine("\nVector ordenado con el método de selección:");
        foreach (int numero in vector)
        {
            Console.Write(numero + " ");
        }
    }
}
