using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según 
            //los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.

            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final
            // con el descuento que corresponda.

            


            float TotalCompra, ImporteFinal;

            Console.WriteLine("Ingrese el total de la compra: ");
            TotalCompra = float.Parse(Console.ReadLine());

            if(TotalCompra >= 5000)
                ImporteFinal = TotalCompra * 0.82F;
            else if(TotalCompra >= 1000)
                ImporteFinal = TotalCompra * 0.90F;
            else
                ImporteFinal = TotalCompra;

            Console.WriteLine("El precio final es: " + ImporteFinal);


                





        }
    }
}
