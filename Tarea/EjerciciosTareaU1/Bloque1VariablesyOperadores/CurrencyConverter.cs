//Ejercicio #1: Conversor de monedas
namespace VariablesyOperadores;
public class   CurrencyConverter
{
    public void Convertion()
    {

        double lempiras = LeerPositivo("Ingrese la cantidad de dinero en Lempiras: ");

        double tasadolar= LeerPositivo("Ingrese la tasa de cambio de el dólar en Lempiras: ");

        double tasaeuro = LeerPositivo("Ingrese la tasa de cambio de el euro en Lempiras: ");

        double dolares = lempiras / tasadolar;
        double euros = lempiras / tasaeuro;

        Console.WriteLine($"La cantidad de dinero en dólares es: {dolares:F2}");
        Console.WriteLine($"La cantidad de dinero en euros es: {euros:F2}");
    }
    private double LeerPositivo(string mensaje)
{
    double valor;
    Console.Write(mensaje);
    while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        Console.Write("Inválido, Ingrese un valor positivo: ");
    return valor;
}
}

