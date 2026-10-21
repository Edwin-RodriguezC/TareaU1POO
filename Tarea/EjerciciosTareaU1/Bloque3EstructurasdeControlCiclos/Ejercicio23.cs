//Ejercicio #23: Tabla de multiplicar extendida
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio23
    {
        public void Ejecutar()
        {
            int numero = LeerEntero("Ingrese un número entero: ");

            Console.WriteLine();
            Console.WriteLine($"Tabla de multiplicar del {numero}");
            
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;

                // Se alinean las columnas 
                Console.WriteLine($"{numero,5} x {i,2} = {resultado,7}");
            }
        }
        //Validacion de entradas
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
