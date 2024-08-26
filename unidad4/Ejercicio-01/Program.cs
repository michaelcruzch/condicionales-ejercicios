using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int n1, n2, Resta, Suma, Producto;

            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                Resta = n1 - n2;
                Console.WriteLine("El resultado de la resta es: " + Resta);
            }else if(n1 == n2){
                Suma = n1 + n2;
                Console.WriteLine("El restultado de la suma es: " + Suma);
            }else{
                Producto = n1 * n2;
                Console.WriteLine("El resultado de la multiplicacion es: " + Producto);
            }


        }
    }
}
