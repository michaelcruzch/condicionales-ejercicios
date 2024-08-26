using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros 
            //es mayor al producto del segundo con el tercero.


            int n1, n2, n3, suma, producto;

            Console.WriteLine("Ingrese el primero numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            n3 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n2 * n3;

            if(suma > producto)
                Console.WriteLine("El resultado de la Suma es mayor al resultado del producto");
            else
                Console.WriteLine("El resultado del producto es mayor al resultado de la suma");


        }
    }
}
