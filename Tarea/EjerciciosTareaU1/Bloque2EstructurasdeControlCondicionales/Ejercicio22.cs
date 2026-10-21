//Ejercicio #22: Cajero automático
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Ejercicio22
{
    public void Ejecutar()
    {
        int saldo = 5000;   // Declaro el saldo inicial como 5000 Lempiras
        Console.WriteLine($"Saldo disponible: L {saldo}");

        int monto = LeerMonto();

        if (monto % 20 != 0)
        {
            Console.WriteLine("El monto debe ser múltiplo de 20.");
            return;
        }

        if (monto > saldo)
        {
            Console.WriteLine("Fondos insuficientes.");
            return;
        }

        saldo = saldo - monto;

        // Primero Los billetes grandes 
        int resto = monto;
        int billetes500 = resto / 500;
        resto = resto % 500;
        int billetes100 = resto / 100;
        resto = resto % 100;
        int billetes20 = resto / 20;

        Console.WriteLine("Retiro exitoso. Billetes entregados:");
        if (billetes500 > 0)
            Console.WriteLine($"{billetes500} de L 500");
        if (billetes100 > 0)
            Console.WriteLine($"{billetes100} de L 100");
        if (billetes20 > 0)
            Console.WriteLine($"{billetes20} de L 20");
        Console.WriteLine($"Nuevo saldo: L {saldo}");
    }
// Validacion de entradas
    private int LeerMonto()
    {
        int valor;
        Console.Write("Ingrese el monto a retirar: L ");
        while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            Console.Write("Inválido, ingrese un monto mayor que 0: ");
        return valor;
    }
}
}