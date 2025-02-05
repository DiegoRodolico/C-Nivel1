namespace Unidad_2_Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
      //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

      int n1, r;
      Console.WriteLine("escribite un numero querido");
      n1 = int.Parse(Console.ReadLine());
      r = n1*n1*n1;
      Console.WriteLine("elresultado del cubo es" + r);
      // cuando mostramos le tenemos que concatenar con un "+"
    }
}
