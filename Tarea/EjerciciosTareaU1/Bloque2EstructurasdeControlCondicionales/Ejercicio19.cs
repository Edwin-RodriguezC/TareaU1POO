//Ejercicio #19: Clasificación de triángulos
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{

public class Ejercicio19
{
    public void Ejecutar()
    {
        double a = LeerPositivo("Lado 1: ");
        double b = LeerPositivo("Lado 2: ");
        double c = LeerPositivo("Lado 3: ");

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Con esos lados no se puede formar un triángulo.");
            return;
        }

        string porLados;
        if (a == b && b == c)
            porLados = "equilátero";
        else 

        if (a == b || a == c || b == c)
            porLados = "isósceles";
        else
            porLados = "escaleno";

        //Comparo el mayor con el otro dos
        double mayor = Math.Max(a, Math.Max(b, c));
        double cuadradoMayor = mayor * mayor;
        double otros = a * a + b * b + c * c - cuadradoMayor;

        // Calculo por sus angulos
        string porAngulos;
        if (Math.Abs(cuadradoMayor - otros) < 0.0001)
            porAngulos = "rectángulo";
        else

        if (cuadradoMayor < otros)
            porAngulos = "acutángulo";
        else
            porAngulos = "obtusángulo";

        Console.WriteLine($"Es un triángulo {porLados} y {porAngulos}");
    }
// Validacion de entradas
    private double LeerPositivo(string mensaje)
    {
        double valor;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            Console.Write("Inválido, ingrese un valor positivo: ");
        return valor;
    }
}
}
