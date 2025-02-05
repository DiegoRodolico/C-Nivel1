namespace Ejercicio1._4;

class Program
{
    static void Main(string[] args)
    {
        //4. Dada una lista de 10 números enteros, cargarlos en un vector. Luego,
        //determinar e informar si el vector está ordenado en forma creciente. Por
        //ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7
        //y 9 no lo está.

        int n;
        int [] numeros = new int [10];

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingrese 10 numerales");
            n = int.Parse(Console.ReadLine());
            numeros [x] = n;
        }

        //para saber si esta en forma creciente, hay que comparar el primero con el segundo y eso compararlo con el tercero y eso con el cuarto y asi, seria con un if? vamos a ver

        int max = numeros [0];
        for (int x = 0; x < 10; x++)
        {
            if (numeros[x] > max )
            max = numeros [x];
        }
        Console.Writeline ("es creciente");
    }
}
