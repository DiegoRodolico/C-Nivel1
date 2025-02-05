namespace Ejercicio2._2;

class Program
{
    static void Main(string[] args)
    {
       //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        int [] numeros = new int [10];
       for (int x = 0; x < 10; x++)
       {
        Console.WriteLine("Ingrese 10 numerales");
        numeros[x] = int.Parse(Console.ReadLine());

       }
        int promedio = 0;
        int resultadopromedio;
        for (int x = 0; x < 10; x++)
        {
            promedio += numeros [x];
        }
        resultadopromedio = promedio /10 ;
        Console.WriteLine("El promedio es : " + resultadopromedio);
        for (int x = 0; x < 10; x++)
        {
            if (numeros [x] > resultadopromedio)
            Console.WriteLine("Estos numeros son mayores al promedio: " + numeros[x]);
        }


       
        

    }
}
