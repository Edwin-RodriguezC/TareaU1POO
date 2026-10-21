//Ejercicio #16: Sistema de cálculo UNAH
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Ejercicio16
{
    public void Ejecutar()
    {
        double nota = LeerNota();
        string letra;
        string descripcion;

        if (nota >= 90) { letra = "A"; descripcion = "Excelente"; }
        else 

        if (nota >= 80) { letra = "B"; descripcion = "Muy bueno"; }
        else 

        if (nota >= 70) { letra = "C"; descripcion = "Bueno"; }
        else 

        if (nota >= 60) { letra = "D"; descripcion = "Regular"; }
        else { letra = "F"; descripcion = "Insuficiente"; }

        string resultado = nota >= 60 ? "Aprobado" : "Reprobado";

        Console.WriteLine($"Nota: {nota}");
        Console.WriteLine($"Letra: {letra} ({descripcion})");
        Console.WriteLine($"Resultado: {resultado}");
    }
// Validacion de entradas
    private double LeerNota()
    {
        double valor;
        Console.Write("Ingrese la nota (0-100): ");
        while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0 || valor > 100)
            Console.Write("Inválido, la nota debe estar entre 0 y 100: ");
        return valor;
    }
}
}