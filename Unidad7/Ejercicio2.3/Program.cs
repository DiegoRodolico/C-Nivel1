namespace Ejercicio2._3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
        //CADENA FUENTE: “La mar estaba serena"
        //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //CADENA RESULTADO: “Li mir estibi sereni"

        char[] cadena = new char [30] ;
        char letra1; char letra2;
        char letra;
        int indice = 0;
        Console.WriteLine ("Ingrese una letra ");
        letra = char.Parse(Console.ReadLine());
        while (letra != '0' && indice < 30)
        {
            cadena[indice] = letra;
            Console.WriteLine ("Ingrese otra letra ");
            letra = char.Parse(Console.ReadLine());
            indice++;
        }
        cadena[indice] = '\0';
        indice = 0;
        Console.WriteLine("La frase es :");
        while (cadena [indice] != '\0')
        {
            Console.Write (cadena[indice]);
            indice++;
        }

            //esto es un quilombo es un array a bajo nivel, depsues se usa a alto nivel con string, pero iwal es dificil, no quiero hacer mas jaja.


    }
}
