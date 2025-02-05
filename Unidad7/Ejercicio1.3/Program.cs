namespace Ejercicio1._3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa que solicite 100 números enteros y los guarde en un
        //vector. Luego recorrer ese vector para calcular el promedio. Mostrar por
        //pantalla los valores del vector que son mayores al promedio calculado.
    
        int n ;
        int [] numeros = new int [100];

        for (int x = 0; x < 100; x++)                   
        {
            Console.WriteLine("ingrese numeros");
            n = int.Parse (Console.ReadLine());
            numeros [x] = n;
        }

        int acu = 0;
        int promedio = 0;
        for (int x = 0; x < 100; x++)
        {
            acu += numeros [x];
        }
        promedio = acu /100;

        for (int x = 0; x < 100; x++)  
        {
            if (numeros [x] > promedio);
            Console.WriteLine("es mayor al promedio");
        }
        
    }


}
