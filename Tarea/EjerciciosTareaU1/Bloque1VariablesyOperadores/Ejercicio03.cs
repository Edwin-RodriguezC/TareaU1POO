//Ejercicio #3: Intercambio de valores
namespace Tarea.EjerciciosTareaU1.Bloque1VariablesyOperadores
{
    public class Ejercicio03
    {
         public void Intercambio(int a, int b)
{
    Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");

    // Intercambio con variable temporal(Antes del reto)
    int temp = a;
    a = b;
    b = temp;

    Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
}
        private int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
                Console.Write("Inválido, Ingrese un valor entero: ");
            return valor;
        }
       public void IntercambioReto(int a, int b)
{
    Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");

    //Reto sin variable temporal con operaciones aritmeticas
    a = a + b;   
    b = a - b;   
    a = a - b;   

    Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
} 
    }
}