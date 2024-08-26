using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros
            // vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.


            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y
            // calcule y emita el importe con el descuento  aplicado..

            float ImporteVenta, CantidadLitros, TotalPagar;

            Console.WriteLine("Ingrese el importe total de la venta:");
            ImporteVenta = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendidos:");
            CantidadLitros = float.Parse(Console.ReadLine());

            if(CantidadLitros > 500){
                TotalPagar = ImporteVenta * 0.75F;
                Console.WriteLine("El total a pagar con el descuento aplicado es: " + TotalPagar);
            }else if(CantidadLitros >= 301 && CantidadLitros <= 500){
                TotalPagar = ImporteVenta * 0.85F;
                Console.WriteLine("El total a pagar con el descuento aplicado es: " + TotalPagar);
            }else if(CantidadLitros >= 101 && CantidadLitros <= 300){
                TotalPagar = ImporteVenta * 0.90F;
                Console.WriteLine("El total a pagar con el descuento aplicado es: " + TotalPagar);
            }else
                Console.WriteLine("El total a pagar es: " + ImporteVenta);





        }
    }
}
