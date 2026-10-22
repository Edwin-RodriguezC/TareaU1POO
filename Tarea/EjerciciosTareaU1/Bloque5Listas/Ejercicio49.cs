//Ejercicio #49: Separar pares e impares
namespace Tarea.EjerciciosTareaU1.Bloque5Listas
{
    public class Ejercicio49
    {
        public void Ejecutar()
        {
            List<int> numeros = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 1; i <= 15; i++)
            {
                Console.Write($"Número {i}: ");
                numeros.Add(int.TryParse(Console.ReadLine(), out int n) ? n : 0);
            }

            //Tambien sirve con negativos
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                }
            }
//Ordena los pares y impares
            pares.Sort();
            impares.Sort();

            Mostrar("Pares ordenados", pares);
            Mostrar("Impares ordenados", impares);
        }
//Validacion de entradas
        private void Mostrar(string titulo, List<int> lista)
        {
            Console.Write($"{titulo} ({lista.Count}): ");

            if (lista.Count == 0)
            {
                Console.Write("ninguno");
            }

            foreach (int numero in lista)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine();
        }
    }
}