//Ejercicio #29. Serie Fibonacci 
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio29
    {
        public void Realizar()
        {
            // Límite de 40 para que los valores no se salgan del rango de int
            int n = LeerEnRango("Ingrese cuántos términos desea (1 a 40): ", 1, 40);

            int anterior = 0;
            int actual = 1;
            int suma = 0;

            Console.WriteLine($"Los primeros {n} términos de Fibonacci son:");

            for (int i = 1; i <= n; i++)
            {
                // Se muestra el término y se acumula en la suma
                Console.Write(i < n ? $"{anterior}, " : $"{anterior}");
                suma += anterior;

                // Se calcula el siguiente término
                int siguiente = anterior + actual;
                anterior = actual;
                actual = siguiente;
            }

            double promedio = (double)suma / n;

            Console.WriteLine();
            Console.WriteLine($"Suma total: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }

        // Repite la lectura hasta que el entero esté dentro del rango
        private int LeerEnRango(string mensaje, int minimo, int maximo)
        {
            Console.Write(mensaje);
            int valor = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            while (valor < minimo || valor > maximo)
            {
                Console.Write($"Inválido, ingrese un entero entre {minimo} y {maximo}: ");
                valor = int.TryParse(Console.ReadLine(), out int m) ? m : 0;
            }

            return valor;
        }
    }
}