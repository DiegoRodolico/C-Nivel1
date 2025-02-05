namespace Ejercicio2._1;

class Program
{
    static void Main(string[] args)
    {
        //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int [] numeros = new int [10];

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingresa 10 numeracos");
            numeros [x] = int.Parse(Console.ReadLine());
        }

        int max = numeros[0];
        int posicion = 1;

        for (int x = 0; x < 10; x++)
        {
            if (numeros [x]> max){
            max = numeros [x];
            posicion =  x + 1;
            }
            
        }
        Console.WriteLine ("El maximo es :" + max );
        Console.WriteLine (" y su lugar es: " + posicion);

    }
}
