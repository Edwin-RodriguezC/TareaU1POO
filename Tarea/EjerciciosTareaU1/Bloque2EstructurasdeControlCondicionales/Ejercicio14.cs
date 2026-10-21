//Ejercicio #14: Calculadora con switch
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Ejercicio14
{
    public void Ejecutar()
    {
        Console.WriteLine("Calculadora con switch");
        Console.WriteLine("Operaciones: +  -  *  /  %");
        Console.Write("Elija la operación: ");
        string operacion = Console.ReadLine() ?? "";

        double n1 = LeerNumero("Primer número: ");
        double n2 = LeerNumero("Segundo número: ");

        switch (operacion)
        {
            case "+":
                Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                break;
            case "-":
                Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                break;
            case "*":
                Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                break;
            case "/":
                if (n2 == 0)
                    Console.WriteLine("Error: no se puede dividir entre cero");
                else
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                break;
            case "%":
                if (n2 == 0)
                    Console.WriteLine("Error: no se puede sacar el módulo entre cero");
                else
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                break;
            default:
                Console.WriteLine("Operación inválida");
                break;
        }
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