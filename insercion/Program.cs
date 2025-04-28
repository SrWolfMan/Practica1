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
        Console.WriteLine("Array original:");
        foreach (int numero in vector)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        // Implementación del método de inserción para ordenar el array
        int n = vector.Length;

        // Comenzamos desde el segundo elemento (índice 1)
        for (int i = 1; i < n; i++)
        {
            int clave = vector[i]; // Elemento a insertar
            int j = i - 1;

            // Desplazamos los elementos mayores que la clave una posición a la derecha
            while (j >= 0 && vector [j] > clave)
            {
                vector[j + 1] = vector[j];
                j--;
            }

            // Colocamos la clave en su lugar correcto
            vector[j + 1] = clave;
        }

        // Mostrar el array ordenado
        Console.WriteLine("\nArray ordenado con el método de inserción:");
        foreach (int numero in vector)
        {
            Console.Write(numero + " ");
        }
    }
}
