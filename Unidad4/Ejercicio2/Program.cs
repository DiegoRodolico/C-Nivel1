namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
     //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
     //Si vende menos de 100 litros, no hay descuento.
     //Si vende entre 101 y 300 litros, el descuento es del 10%.
     //Si vende entre 301 y 500 litros, el descuento es del 15%.
     //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
     //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.
    
    double litros, venta;
    Console.WriteLine("Ingresa el importe total de la venta");
    venta = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa la cantidad de litros vendidos");
    litros = double.Parse(Console.ReadLine());
    if (litros > 500)
    venta = (venta * 0.75); 
    else if (litros > 301)
    venta = (venta * 0.85); 
    else if (litros > 101)
    venta = (venta* 0.90 );
    else ;

    Console.WriteLine("El importe total es :" + venta);
    
    }    
}

