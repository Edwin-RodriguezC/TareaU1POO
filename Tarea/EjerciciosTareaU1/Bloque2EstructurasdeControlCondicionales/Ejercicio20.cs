//Ejercicio #20: Año de bisiesto y días del mes
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Ejercicio20
{
    public void Ejecutar()
    {

        int anio = LeerEnRango("Ingrese el año: ", 1, 9999);
        int mes = LeerEnRango("Ingrese el mes (1-12): ", 1, 12);

        // bisiesto 
        bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;

        int dias;
        if (mes == 2)
            dias = bisiesto ? 29 : 28;
        else 
        
        if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            dias = 30;
        else
            dias = 31;

        Console.WriteLine(bisiesto ? $"{anio} es bisiesto" : $"{anio} no es bisiesto");
        Console.WriteLine($"El mes {mes} tiene {dias} días");
    }
// Validacion de entradas
    private int LeerEnRango(string mensaje, int min, int max)
    {
        int valor;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
            Console.Write($"Inválido, ingrese un número entre {min} y {max}: ");
        return valor;
    }
}
}