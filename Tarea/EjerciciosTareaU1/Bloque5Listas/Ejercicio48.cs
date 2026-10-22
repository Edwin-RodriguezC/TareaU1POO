//Ejercicio #48: Números únicos
namespace Tarea.EjerciciosTareaU1.Bloque5Listas
{
    public class Ejercicio48
    {
        public void Ejecutar()
        {
            Console.Write("¿Cuántos números desea ingresar?: ");
            int cantidad = int.TryParse(Console.ReadLine(), out int c) ? c : 0;

            while (cantidad < 1)
            {
                Console.Write("Inválido, ingrese un número mayor a 0: ");
                cantidad = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            }

            List<int> unicos = new List<int>();
            int descartados = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Número {i}: ");
                int numero = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

                // Agregara si no existe en la lista
                if (unicos.Contains(numero))
                {
                    descartados++;
                    Console.WriteLine("Repetido, se descartó.");
                }
                else
                {
                    unicos.Add(numero);
                }
            }
//Validacion de entradas
            Console.WriteLine("Lista resultante:");
            foreach (int numero in unicos)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Duplicados descartados: {descartados}");
        }
    }
}