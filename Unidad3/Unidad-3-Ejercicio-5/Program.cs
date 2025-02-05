namespace Unidad_3_Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

         int n1,n2,n3,n4, con =0;
        Console.WriteLine("Ingresa un numero");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero");
        n4 = int.Parse(Console.ReadLine());
        if (n1> 100) {
            Console.Write(n1 + ", ");
            con++ ;
        } if (n2> 100) {
            Console.Write(n2 + ", ");
            con++ ;
        } if (n3> 100) {
            Console.Write(n3 + ", ");
            con++ ;
        } if (n4> 100) {
            Console.Write(n4 + ", ");
            con++ ; 
        } if (con != 0) 
         
        Console.WriteLine("Son mayores a 100:");
        
    }
}
