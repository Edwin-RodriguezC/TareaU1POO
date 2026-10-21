
//Ejercicio #24: Suma de pares e impares
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos

{
    public class Ejercicio24
    {
        public void Ejecutar()
        {
            int n = LeerPositivo("Ingrese el valor de N (mayor que 0): ");

            int sumaPares = 0;
            int cantidadPares = 0;
            int sumaImpares = 0;
            int cantidadImpares = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    // Número par
                    sumaPares += i;
                    cantidadPares++;
                }
                else
                {
                    // Número impar
                    sumaImpares += i;
                    cantidadImpares++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Números del 1 al {n}");
            Console.WriteLine($"Pares: cantidad = {cantidadPares}, suma = {sumaPares}");
            Console.WriteLine($"Impares: cantidad = {cantidadImpares}, suma = {sumaImpares}");
        }
//validacion de entradas
        private int LeerPositivo(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                Console.Write("Inválido, ingrese un número entero mayor que 0: ");
            return valor;
        }
    }
}