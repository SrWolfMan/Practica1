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




        // mostramos el vector original antes de ordenarlo
        Console.WriteLine("Vector original:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }

        int n = vector.Length;

        // recorremos el vector varias veces
        for (int i = 0; i < n - 1; i++)
        {
            // en cada recorrido, comparamos los elementos de dos en dos
            for (int j = 0; j < n - i - 1; j++)
            {
                // Si el número actual es mayor que el siguiente los intercambiamos usando una variable temporal
                if (vector[j] > vector[j + 1])
                {
                    
                    int temp = vector[j];          // guardamos el valor original
                    vector[j] = vector[j + 1];     // el actual toma el valor del siguiente
                    vector[j + 1] = temp;          // y el siguiente toma el valor guardado en temp
                }
            }
        }

        // mostramos el vector ya ordenado
        Console.WriteLine("\n\nvector ordenado:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }
    }
}
