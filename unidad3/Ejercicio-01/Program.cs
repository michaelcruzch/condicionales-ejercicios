using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio 
            //si “Es mayor a 10” o “No es mayor a 10”.

            int Numero;

            Console.WriteLine("Ingrese un numero: ");
            Numero = int.Parse(Console.ReadLine());

            if(Numero > 10)
                Console.WriteLine("El numero es mayor a 10");
            else    
                Console.WriteLine("El numero no es mayor a 10");


        }
    }
}
