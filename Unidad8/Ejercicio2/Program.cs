namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        int [] numeros = new int [20];
        int n1 ;
        int acu = 0;
        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("ingrese 20 numeros");
            numeros[x] = int.Parse(Console.ReadLine());
            n1 = par (numeros [x]);
            acu += n1;

        }
            Console.WriteLine("los que son pares son : " + acu);
        static int par(int a){
            if ( a % 2 == 0)
            return 1;
            else 
            return 0; 
        }
    }
}
