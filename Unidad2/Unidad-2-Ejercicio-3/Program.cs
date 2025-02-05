using System.Timers;
namespace Unidad_2_Ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

        float km, vp, Tiempo;
        Console.WriteLine ("ingresarme los kilometros perro");
        km = float.Parse (Console.ReadLine());
        Console.WriteLine ("ahora decime la velocidad promedio");
        vp = float.Parse (Console.ReadLine());
        Tiempo = km/vp;d
        Console.WriteLine ("el tiempo que vas a tardar es :" + Tiempo.ToString("0.00")  + " horas , maquina.");
    }
}
