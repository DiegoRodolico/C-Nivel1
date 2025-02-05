namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
    //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

    int n1, n2, n3, suma, producto;
    Console.WriteLine("Ingresa un numeral");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa un numeral");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa un numeral");
    n3 = int.Parse(Console.ReadLine());

    suma = n1 + n2 ;
    producto = n2 * n3;
    
    if (suma > producto)
        Console.WriteLine ("Cartel aclaratorio");

    }
}
