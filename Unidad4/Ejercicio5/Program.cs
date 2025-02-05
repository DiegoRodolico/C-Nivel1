namespace Ejercicio5;

class Program
{
    static void Main(string[] args)
    {
    //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

    int a, b, c, d;
    Console.WriteLine("Ingrese un Numero: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro Numero: ");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro Numero: ");
    c = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro Numero: ");
    d = int.Parse(Console.ReadLine());

    if (a > b && b > c && c > d)
        Console.WriteLine("Estan ordenados de forma decreciente");

        else 
        Console.WriteLine("No estan ordenados");
        

    }
}
