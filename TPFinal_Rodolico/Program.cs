namespace TPFinal_Rodolico;

class Program
{
    static void Main(string[] args)
    {
        // int inicio = 10;
        // int intervalo =2;
        // while(inicio >= 0){
        //     Console.Write(inicio + "");
        //     inicio -= intervalo;
        // }
        
        // for (int i = 50; i <=100; i+=2)
        // {
        //     Console.WriteLine(i);
        // }

        int n;
        int suma;
        for (int x = 0; x < 3; x++)
        {
            Console.WriteLine("escribi aca ");
            n = int.Parse(Console.ReadLine());
            suma = 0;
            while(n!=0){
                suma += n+5;
                Console.WriteLine("escribi aca tambien");
                n= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vuelta: " + (x+1) + "la suma fue de : " + suma);
        }

    }
}
