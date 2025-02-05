using System.Diagnostics.CodeAnalysis;

namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
      //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
      //La resta si el primero es mayor que el segundo.
      //La suma si son iguales.
      //El producto si el primero es menor.
      //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
        int a,b,resta,suma,producto;
        Console.WriteLine("Ingresame un numeral");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresame otro numeroide");
        b = int.Parse(Console.ReadLine());
        if (a > b ) {
            resta = a - b;
            Console.WriteLine("Debido a que el primero es mayor que el segundo, el resultado es : " + resta);
        } if (a == b) {
            suma = a + b;
            Console.WriteLine("Debido a que son iguales, el resultado es : " + suma);
        } if (a < b){
            producto = a * b;
            Console.WriteLine("Debido a que el primero es menor que el segundo, el resultado es : " + producto);
        }
        
        
        Console.WriteLine("Fin del progrma...");

    
    
    }
}
