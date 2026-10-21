//Ejercicio 21: Validador de Fecha
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Ejercicio21
{
    public void Ejecutar()
    {
        int dia = LeerEntero("Ingrese el día: ");
        int mes = LeerEntero("Ingrese el mes: ");
        int anio = LeerEntero("Ingrese el año: ");

        bool valida;
        if (anio < 1)
            valida = false;
        else 
        
        if (mes < 1 || mes > 12)
            valida = false;
        else 
        
        if (dia < 1 || dia > DiasDelMes(mes, anio))
            valida = false;
        else
            valida = true;

        if (valida)
            Console.WriteLine($"{dia:00}/{mes:00}/{anio} es una fecha válida");
        else
            Console.WriteLine($"{dia}/{mes}/{anio} no es una fecha válida");
    }

    private int DiasDelMes(int mes, int anio)
    {
        if (mes == 2)
        {
            bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;
            return bisiesto ? 29 : 28;
        }
        if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            return 30;
        return 31;
    }
// Validacion de entradas
    private int LeerEntero(string mensaje)
    {
        int valor;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor))
            Console.Write("Inválido, ingrese un número entero: ");
        return valor;
    }
}
}