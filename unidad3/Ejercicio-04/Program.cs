using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.


            int n1,n2,n3,n4,Menor;

            Console.WriteLine("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero:");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2)
                Menor = n1;
            else
                Menor = n2;
            if(n3 < Menor)
                Menor = n3;
            if(n4 < Menor)
                Menor = n4;

            Console.WriteLine("El numero menor es: " + Menor);


        }
    }
}
