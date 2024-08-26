using System;

namespace Ejecicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos 
            //se encuentran ordenados de forma decreciente .

            int n1, n2, n3, n4, ordenados;

            Console.WriteLine("Ingrese el primero numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero:");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > n2)
                ordenados = 1;
            else
                ordenados = 0;
            if(n3 < n2)
                ordenados = 1;
            else
                ordenados = 0;
            if(n4 < n3)
                ordenados = 1;
            else
                ordenados = 0;
            if(ordenados == 1)
                Console.WriteLine("Los numeros estar ordenados de forma decreciente");
            else
                Console.WriteLine("Los numero no estan ordenados de forma decreciente");

                
                
                
            







        }
    }
}
