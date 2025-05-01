using System;

class QuickSort
{
    static void Main()
    {
        int[] vector = new int[5];
        int inicio = 0;
        int fin = vector.Length - 1;

        Console.WriteLine("Ingrese 5 numeros:");

        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine($"Ingrese el numero {i + 1}");
            vector[i] = int.Parse(Console.ReadLine() ?? "");
        }

        // Pila para manejar los índices de inicio y fin
        int[] pilaInicio = new int[vector.Length];
        int[] pilaFin = new int[vector.Length];
        int tope = -1;

        pilaInicio[++tope] = inicio;
        pilaFin[tope] = fin;

        while (tope >= 0)
        {
            inicio = pilaInicio[tope];
            fin = pilaFin[tope];
            tope--;

            if (inicio < fin)
            {
                int i = inicio;
                int j = fin;
                int pivote = vector[(inicio + fin) / 2];

                while (i <= j)
                {
                    while (vector[i] < pivote) i++;
                    while (vector[j] > pivote) j--;

                    if (i <= j)
                    {
                        int temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                        i++;
                        j--;
                    }
                }

                // Apilar las mitades si tienen más de un elemento
                if (inicio < j)
                {
                    pilaInicio[++tope] = inicio;
                    pilaFin[tope] = j;
                }
                if (i < fin)
                {
                    pilaInicio[++tope] = i;
                    pilaFin[tope] = fin;
                }
            }
        }

        Console.WriteLine("Vector ordenado:");
        foreach (int num in vector)
        {
            Console.WriteLine(num);
        }
    }
}
