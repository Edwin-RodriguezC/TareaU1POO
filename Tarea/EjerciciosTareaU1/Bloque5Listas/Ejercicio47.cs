//Ejercicio #47: Registro de calificaciones
namespace Tarea.EjerciciosTareaU1.Bloque5Listas
{
    public class Ejercicio47
    {
        public void Ejecutar()
        {
            List<double> notas = new List<double>();
            string respuesta;

            // Aca se piden las notas hasya que el usuario no ingrese "s"
            do
            {
                Console.Write($"Nota {notas.Count + 1} (0 a 100): ");
                double nota = double.TryParse(Console.ReadLine(), out double n) ? n : -1;

                // rechaza cualquier valor que sea invalido
                while (!(nota >= 0 && nota <= 100))
                {
                    Console.Write("Inválido, ingrese una nota entre 0 y 100: ");
                    nota = double.TryParse(Console.ReadLine(), out double m) ? m : -1;
                }

                notas.Add(nota);

                Console.Write("¿Desea ingresar otra nota? (s/n): ");
                respuesta = (Console.ReadLine() ?? "").Trim().ToLower();
            } while (respuesta == "s");

            double maxima = notas[0];
            double minima = notas[0];

            foreach (double nota in notas)
            {
                if (nota > maxima)
                {
                    maxima = nota;
                }
                if (nota < minima)
                {
                    minima = nota;
                }
            }

            Console.WriteLine($"Promedio: {Promedio(notas):F2}");
            Console.WriteLine($"Nota máxima: {maxima:F2}");
            Console.WriteLine($"Nota mínima: {minima:F2}");

            notas.Remove(minima);
            Console.WriteLine($"Se eliminó la nota más baja ({minima:F2}).");

            if (notas.Count == 0)
            {
                Console.WriteLine("No quedan notas para calcular el promedio.");
            }
            else
            {
                Console.WriteLine($"Nuevo promedio: {Promedio(notas):F2}");
            }
        }
//Validacion de entradas
        private double Promedio(List<double> notas)
        {
            double suma = 0;

            foreach (double nota in notas)
            {
                suma += nota;
            }

            return suma / notas.Count;
        }
    }
}