namespace Unidad_3_Ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

        int n1,n2,n3,n4, menor;
        Console.WriteLine("Ingresa un numero");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero");
        n4 = int.Parse(Console.ReadLine());
        if (n1< n2) {
            menor = n1 ;
        } else 
            menor = n2 ;{
        } if (n3< menor) {
            menor = n3 ;
        } if (n4< menor) {
            menor = n4 ; 
        }
        Console.WriteLine("El menor de los numeros es :" + menor);
    
    }
}