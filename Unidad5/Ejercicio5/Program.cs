namespace Ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

        int n , max = 0, min = 0, pares = 0, impares = 0;
       
        
        for (int x = 0; x < 20; x++)
        { 
        Console.WriteLine("ingrese nro. :");
        n = int.Parse(Console.ReadLine());
            if (n % 2  == 0)
            pares++;
                if (pares == 1)
                    max = n;
                else if (n > max)
                    max = n;
            else {
            impares++;
                if (impares == 1)
                    min = n;
                else if (n < min)
                    min = n;
            } 
            }
            Console.WriteLine("El maximo es :" + max);
            Console.WriteLine("El minimo es :" + min);
        }
    }
      
            

