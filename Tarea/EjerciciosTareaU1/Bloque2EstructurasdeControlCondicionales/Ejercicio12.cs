//Ejercicio #12: Mayor de tres números
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Ejercicio12
{
    public void Ejecutar()
    {
        double a, b, c;

        do
        {
            a = LeerNumero("Primer número: ");
            b = LeerNumero("Segundo número: ");
            c = LeerNumero("Tercer número: ");

            if (a == b || a == c || b == c)
                Console.WriteLine("Los tres números deben ser diferentes, intente de nuevo.");
        } while (a == b || a == c || b == c);

        double mayor;
        if (a > b && a > c)
            mayor = a;
        else 
        if (b > a && b > c)
            mayor = b;
        else
            mayor = c;

        double menor;
        if (a < b && a < c)
            menor = a;
        else 
        if (b < a && b < c)
            menor = b;
        else
            menor = c;

        Console.WriteLine($"El mayor es: {mayor}");
        Console.WriteLine($"El menor es: {menor}");
    }
// Validacion de entradas
    private double LeerNumero(string mensaje)
    {
        double valor;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out valor))
            Console.Write("Inválido, ingrese un número: ");
        return valor;
    }
}
}