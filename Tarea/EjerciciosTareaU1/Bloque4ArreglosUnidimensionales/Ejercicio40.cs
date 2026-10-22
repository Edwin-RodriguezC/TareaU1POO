//Ejercicio #40: Frecuencia de elementos
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio40
    {
        public void Concretar()
        {
            Random aleatorio = new Random();
            int[] numeros = new int[20];
            int[] frecuencias = new int[11];
            // Se generan los números

            Console.Write("Números generados: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 11);
                frecuencias[numeros[i]]++;
                Console.Write($"{numeros[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Frecuencia de cada número:");
            for (int valor = 1; valor <= 10; valor++)
            {
                Console.WriteLine($"El {valor} aparece {frecuencias[valor]} veces");
            }

            int mayorFrecuencia = frecuencias[1];
            int menorFrecuencia = frecuencias[1];
            for (int valor = 2; valor <= 10; valor++)
            {
                if (frecuencias[valor] > mayorFrecuencia)
                {
                    mayorFrecuencia = frecuencias[valor];
                }
                if (frecuencias[valor] < menorFrecuencia)
                {
                    menorFrecuencia = frecuencias[valor];
                }
            }
//Se muestran los valores iguales
            Console.Write($"Más frecuente ({mayorFrecuencia} veces): ");
            for (int valor = 1; valor <= 10; valor++)
            {
                if (frecuencias[valor] == mayorFrecuencia)
                {
                    Console.Write($"{valor} ");
                }
            }
            Console.WriteLine();

            Console.Write($"Menos frecuente ({menorFrecuencia} veces): ");
            for (int valor = 1; valor <= 10; valor++)
            {
                if (frecuencias[valor] == menorFrecuencia)
                {
                    Console.Write($"{valor} ");
                }
            }
            Console.WriteLine();
        }
    }
}