namespace Ejercicio1._2;

class Program
{
    static void Main(string[] args)
    {
        //2. Hacer un programa que solicite 50 números enteros y los guarde en un vector.
        //Luego recorrer todos los elementos del vector y determinar cuál es el valor
        //máximo y su posición dentro del vector.

        int n;
        int [] numeros = new int[50];

        for (int x = 0; x < 50; x++)
        {
            Console.WriteLine("ingresa los numeros");
            n=int.Parse(Console.ReadLine());
            numeros [x] = n;
        }
        int max = numeros[0]; int pos = 1;
        for (int x = 0; x < 50; x++)
        {
            //para saber el maximo tenes que determinar creo que un if y decir que el primero ingresado es el maximo y luego los demas se comparen con el maximo que pusiste al principio, segun yo * hay que ir a laburar, continualo cuando volves diego daleeee

            if (numeros[x] > max)  ;
            max = numeros[x] ;
            pos = x+1;
        }
        Console.WriteLine("el maximo es : " + max ); 
        Console.WriteLine(" y su posicion es: " + pos);
    }
}
