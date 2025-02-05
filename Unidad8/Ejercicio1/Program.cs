namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

        int n1, n2, pagar;
        Console.WriteLine("escriba el precio del articulo");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("escriba la cantidad vendida ");
        n2 = int.Parse(Console.ReadLine());

        pagar = producto(n1, n2);

        Console.WriteLine("El total a pagar es :" + pagar);
    }
    static int producto(int a, int b)
    {
        int r;
        r = a * b;
        return r;
    }
}
