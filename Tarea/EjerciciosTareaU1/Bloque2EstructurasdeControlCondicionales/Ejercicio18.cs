//Ejercicio #18: Tarifa de estacionamiento
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{

public class Ejercicio18
{
    public void Ejecutar()
    {
        int horas = LeerHoras();

        // La primera hora es de 20 Lempiras
        int pago = 20 + (horas - 1) * 10;


        if (pago > 100)
            pago = 100;

        Console.WriteLine($"Horas estacionado: {horas}");
        Console.WriteLine($"Total a pagar: L {pago}");
    }
// Validacion de entradas
    private int LeerHoras()
    {
        int valor;
        Console.Write("Ingrese las horas estacionado: ");
        while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            Console.Write("Inválido, ingrese un número de horas mayor que 0: ");
        return valor;
    }
}
}