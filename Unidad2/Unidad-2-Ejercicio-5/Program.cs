namespace Unidad_2_Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
       //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

       float n1, n2, n3, nf;
       Console.WriteLine("Primera Nota");
       n1 = float.Parse(Console.ReadLine());
       Console.WriteLine("Segunda Nota");
       n2 = float.Parse(Console.ReadLine());
       Console.WriteLine("Tercera Nota");
       n3 = float.Parse(Console.ReadLine());
       nf = (n1 + n2 + n3)/ 3;
       Console.WriteLine("El promedio es : " + nf.ToString ("0.00"));



    }
}
