namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

        float e = 0, con =0 , acu =0, promedio;
            for (float x  = 0; x < 20; x ++)
                {
                    Console.WriteLine("Ingrese edades");
                    e = float.Parse(Console.ReadLine());
                    if (e > 18) {
                        con++ ;
                        acu+= e ;
                        }
                
                }
            promedio = acu / con;
            Console.WriteLine("El promedio de edad es :" + promedio);
    }
}
