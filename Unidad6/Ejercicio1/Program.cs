﻿namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
     //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

     int n, con, conpri = 0;
     for (int x = 0; x < 10; x++)
     {
        Console.WriteLine("Ingrese numero");
        n = int.Parse(Console.ReadLine());
            con = 0;
            for (int y = 1; y <= n; y++)
            {
                if (n % y == 0)
                con++;
            }
            if (con == 2)
            conpri++;     
            
     } 
     Console.WriteLine("Ingresaste :"  + conpri + " numeros primos");
     Console.WriteLine("El programa termina...");
    }
}
