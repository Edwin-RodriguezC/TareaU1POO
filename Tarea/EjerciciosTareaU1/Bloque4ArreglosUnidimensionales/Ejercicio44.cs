//Ejercicio #44: Histograma de calificaciones
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio44
    {
        public void Concretar()
        {
            int cantidad = LeerEnRango("¿Cuántas calificaciones desea registrar? (1 a 100): ", 1, 100);
            int[] calificaciones = new int[cantidad];

            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = LeerEnRango($"Calificación {i + 1} (0 a 100): ", 0, 100);
            }

            string[] rangos = { "0-59", "60-69", "70-79", "80-89", "90-100" };
            int[] conteos = new int[5];

            //Se suma 1 para cada rango
            foreach (int calificacion in calificaciones)
            {
                if (calificacion <= 59)
                {
                    conteos[0]++;
                }
                else 
                if (calificacion <= 69)
                {
                    conteos[1]++;
                }
                else 
                if (calificacion <= 79)
                {
                    conteos[2]++;
                }
                else 
                if (calificacion <= 89)
                {
                    conteos[3]++;
                }
                else
                {
                    conteos[4]++;
                }
            }

            //Calificacion por rango
            Console.WriteLine("Histograma de calificaciones:");
            for (int i = 0; i < rangos.Length; i++)
            {
                Console.Write($"{rangos[i],-7}| ");

                for (int j = 0; j < conteos[i]; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine($" ({conteos[i]})");
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

        private int LeerEnRango(string mensaje, int minimo, int maximo)
        {
            int valor = LeerEntero(mensaje);

            while (valor < minimo || valor > maximo)
            {
                Console.WriteLine($"Fuera de rango, debe estar entre {minimo} y {maximo}.");
                valor = LeerEntero(mensaje);
            }

            return valor;
        }
    }
}