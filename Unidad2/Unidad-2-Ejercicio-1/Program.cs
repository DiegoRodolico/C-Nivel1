namespace Unidad_2_Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        //1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.;
        int n1, n2, r;
      Console.WriteLine("escribir un numero");
      n1 = int.Parse (Console.ReadLine()); 
      Console.WriteLine ("escribir otro numero");
      n2 = int.Parse (Console.ReadLine());
      r = n1+ n2;
      Console.WriteLine(r);

    

}
}
