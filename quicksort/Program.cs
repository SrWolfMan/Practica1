using System;

class QuickSort{

    static void Main(){

        int []vector = new int[5];
        int inicio = 0;
        int fin = vector.Length-1;

        Console.WriteLine("Ingrese 5 numeros:");

        for (int i = 0; i<vector.Length;i++){
            Console.WriteLine($"Ingrese el numero {i+1}");
            vector[i] = int.Parse(Console.ReadLine()??"");
        }

        foreach (int i in vector){
            Console.WriteLine(vector[i]);
        }

        int []pilaInicio = new int[vector.Length];
        int []pilaFin = new int[vector.Length];
        int tope = -1
        int pivote = vector[2];

        
        
    }
}