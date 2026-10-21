//Ejercicio #13: Día de la semana
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{}
public class Ejercicio13
{
    public void Ejecutar()
    {
        int dia = LeerDia();

        string nombre;
        switch (dia)
        {
            case 1: nombre = "Lunes"; 
            break;
            case 2: nombre = "Martes"; 
            break;
            case 3: nombre = "Miércoles"; 
            break;
            case 4: nombre = "Jueves"; 
            break;
            case 5: nombre = "Viernes"; 
            break;
            case 6: nombre = "Sábado"; 
            break;
            case 7: nombre = "Domingo"; 
            break;
            default: nombre = "Día inválido"; 
            break;
        }
        Console.WriteLine($"Con switch Clasico: {nombre}");

        string nombre2 = dia switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            4 => "Jueves",
            5 => "Viernes",
            6 => "Sábado",
            7 => "Domingo",
            _ => "Día inválido",
            

        };
        Console.WriteLine($"Con expresion switch: {nombre2}");
    }
// Validacion de entradas
    private int LeerDia()
    {
        int valor;
        Console.Write("Ingrese un número del 1 al 7: ");
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < 1 || valor > 7)
            Console.Write("Inválido, ingrese un número entre 1 y 7: ");
        return valor;
    }
}