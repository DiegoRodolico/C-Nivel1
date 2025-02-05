namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
       //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

    int numero;
    int acu = 0;
    int con = 0;
    int promedioprimos = 0;
     Console.WriteLine("ingrese numeros y corte con cero");
     numero = int.Parse (Console.ReadLine());
    while (numero != 0)
    {
       Console.WriteLine("ingrese otro numeros y corte con cero");
       numero = int.Parse (Console.ReadLine());
        if (Primo(numero)){;
        acu += numero;
        con ++ ;
        }

    }
    promedioprimos = acu /con ;
    Console.WriteLine("El promedio de numeros primos es:" + promedioprimos);
    }

    static bool Primo (int a)
    {
        int con = 0;
        for (int x = 1; x <= a; x++)
        {
            if (a % x  == 0)
            con++;
        }
                if (con == 2)
                    return true ;
                else 
                    return false;
        }
    }

