namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.
          int n1= 0, n2 = 0;
          Console.WriteLine("escribir algo");
          n1 = int.Parse(Console.ReadLine());
          Console.WriteLine("escribir algo");
          n2 = int.Parse(Console.ReadLine());
          positivoNegativoCero (n1, ref n2);  
    }
    static void positivoNegativoCero(int a, ref int b){
        
        
        if (a > 0){
        int b = 1;
        } if (a < 0) {
        int b = -1;
        } else { int b = 0;
        }
    }
}
//no lo voy a usar nunca a esto jaja, ya fue, termino aca, despues se corregira el error, quiero avanzaar hacia el trabajo final vamo arriba!
