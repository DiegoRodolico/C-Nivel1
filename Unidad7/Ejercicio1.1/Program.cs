namespace Ejercicio1._1;

class Program
{
    static void Main(string[] args)
    {
        //1. Hacer un programa que solicite 50 números enteros y los guarde en un vector.
        //Luego recorrer el vector y determinar e informar cuál es la suma de los valores
        //del mismo.
        //Nota: usar dos ciclos: uno para guardar los números en el vector y otro para
        //recorrerlo y leerlo.

        int n;
        int [] numeros = new int [50];
        for (int x = 0; x < 50; x++)
        {   
            Console.WriteLine ("Ingresa los numeros");
            n = int.Parse(Console.ReadLine());
            numeros [x] = n;
        }
        int acu = 0;
        for (int x = 0; x < 50; x++)
        {
            acu += numeros[x]; 
        }
        Console.WriteLine("la suma es : " + acu);
    }   
}
