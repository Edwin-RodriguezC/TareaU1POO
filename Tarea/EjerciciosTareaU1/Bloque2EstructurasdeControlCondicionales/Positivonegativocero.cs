
//Ejercicio #11: Positivo o negativo
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Positivonegativocero
{
    public void Ejecutar()
    {
        int numero = LeerEntero("Ingrese un número entero: ");

        if (numero > 0)
            Console.WriteLine("El número es positivo");
        else 
        if (numero < 0)
            Console.WriteLine("El número es negativo");
        else
            Console.WriteLine("El número es cero");

        //Ternario
        string tipo = numero % 2 == 0 ? "par" : "impar";
        Console.WriteLine($"Además, es {tipo}");
    }

    private int LeerEntero(string mensaje)
    {
        int valor;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor))
            Console.Write("Inválido, ingrese un número entero: ");
        return valor;
    }
}
}