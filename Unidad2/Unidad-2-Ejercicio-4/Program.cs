namespace Unidad_2_Ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
       //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

       float facturado, sueldo;
       const float fijo = 15000;
       const float comision = 0.05f;
       Console.WriteLine ("cuanto facturo el esclavo?");
       facturado = float.Parse (Console.ReadLine ());
       sueldo = fijo + (facturado * comision);
       Console.WriteLine ("su roñoso sueldo es = $" + sueldo);
       //const hace una variable en constante , la vuelve fija a la variable sirve para estos casos de cambios en el futuro.






}

}