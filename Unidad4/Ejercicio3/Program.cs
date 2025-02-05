using System.Threading.Tasks.Dataflow;

namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
        //           i5 (1)	 i7 (2)  i9 (3)
        //8 RAM (1)	USD 800	USD 900	USD 1200
        //16 RAM(2) USD 900	USD 1000USD 1400
        //32 RAM(3) USD 1000USD 1400USD 2000
        //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

        float cpu, ram, disco;
        float dolarucos = 0;
        Console.WriteLine("Ingrese el Procesador que gusta querido: 1 para un i5, 2 para un i7, 3 para un i9...");
        cpu = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la memoria Ram que gusta querido : 1 para 8gb ram, 2 para 16gb ram, 3 para 32 gb ram...");
        ram = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Disco que gusta querido: 1 tb (300 lechugas mas) presione 1 o 500gb presione 2");
        disco = float.Parse(Console.ReadLine());
    
        if (cpu  == 1 && ram == 1) 
        dolarucos = 800;
        else if (cpu  == 1 && ram == 2) 
        dolarucos = 900;
        else if (cpu  == 1 && ram == 3) 
        dolarucos = 1200; 
        else if (cpu  == 2 && ram == 1) 
        dolarucos = 900;
        else if (cpu  == 2 && ram == 2) 
        dolarucos = 1000; 
        else if (cpu  == 2 && ram == 3) 
        dolarucos = 1400; 
        else if (cpu  == 3 && ram == 1) 
        dolarucos = 1200; 
        else if (cpu  == 3 && ram == 2) 
        dolarucos = 1400; 
        else if (cpu  == 3 && ram == 3) 
        dolarucos = 2000;
    
        if (disco == 1)
        dolarucos = dolarucos + 300;

        Console.WriteLine("el total gastado seria : " + dolarucos);

        //averiguar porque hay que inicializar la variable dolarucos en 0, 
        //En este caso, si, estas iniciando la variable. Aunque mejor dicho.
        //ESTARIAS iniciando la variable, solamente si el IF da VERDADERO y entra a evaluar tus instrucciones.
        //Por lo que en realidad, la variable no esta 100% asignada, solo estaria asignada en casos supuestos y específicos,
        //Entonces el compilador entiende que hay caminos en los cuales no se le escribe nada, y si eso sucede, no podemos ejecutar el WriteLine leyendo esa variable "no asignada",por lo que el compilador, no compila y da este hermoso error.
        //Se puede en vez de terminar con un "else if", terminarlo con un "else" o iniciliazarlo en 0, asi esta cubierto en todos los caminos esa variable.
       
       
       
       
      


    }
}
