//Ejercicio #17: Calculadora de descuentos
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{

public class Ejercicio17
{
    public void Ejecutar()
    {
        double monto = LeerPositivo("Ingrese el monto de la compra: L ");
        double porcentaje;

        if (monto >= 2500)
            porcentaje = 15;
        else

        if (monto >= 1000)
            porcentaje = 10;
        else
         
        if (monto >= 500)
            porcentaje = 5;
        else
            porcentaje = 0;

        double descuento = monto * porcentaje / 100;
        double precioFinal = monto - descuento;

        Console.WriteLine($"Precio original: L {monto:F2}");
        Console.WriteLine($"Descuento ({porcentaje}%): L {descuento:F2}");
        Console.WriteLine($"Precio final: L {precioFinal:F2}");
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