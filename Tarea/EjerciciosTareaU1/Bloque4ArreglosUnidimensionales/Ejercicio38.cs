//Ejercicio #38: Arreglo de nombres
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio38
    {
        public void Concretar()
        {
            string[] nombres = new string[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = LeerTexto($"Nombre {i + 1}: ");
            }

            Console.WriteLine("Nombres en orden inverso:");
            for (int i = nombres.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i + 1}. {nombres[i]}");
            }

         //Aqui si hay empate se selecciona el primero
            string masLargo = nombres[0];
            for (int i = 1; i < nombres.Length; i++)
            {
                if (nombres[i].Length > masLargo.Length)
                {
                    masLargo = nombres[i];
                }
            }
            Console.WriteLine($"Nombre más largo: {masLargo} ({masLargo.Length} letras)");

            // Búsqueda sin distinguir mayúsculas de minúsculas
            string buscado = LeerTexto("Ingrese el nombre a buscar: ");
            bool encontrado = false;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].ToLower() == buscado.ToLower())
                {
                    Console.WriteLine($"\"{nombres[i]}\" se encontró en la posición {i + 1}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El nombre \"{buscado}\" no está en el arreglo");
            }
        }
        // Validacion de entradas 
        private string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            string texto = (Console.ReadLine() ?? "").Trim();

            while (texto == "")
            {
                Console.Write("Inválido, no puede estar vacío: ");
                texto = (Console.ReadLine() ?? "").Trim();
            }

            return texto;
        }
    }
}