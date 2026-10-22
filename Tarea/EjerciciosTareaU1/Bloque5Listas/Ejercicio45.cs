//Ejercicio #45: Lista de tareas pendientes
namespace Tarea.EjerciciosTareaU1.Bloque5Listas
{
    public class Ejercicio45
    {
        public void Ejecutar()
        {
            List<string> tareas = new List<string>();
            int opcion;

            do
            {
                Console.Clear();//Para mejorar la presentacion
                Console.WriteLine("1.Agregar tarea");
                Console.WriteLine("2.Mostrar tareas");
                Console.WriteLine("3.Eliminar tarea");
                Console.WriteLine("4.Total de tareas");
                Console.WriteLine("5.Salir");
                opcion = int.TryParse(Console.ReadLine(), out int o) ? o : 0;

                switch (opcion)
                {
                    case 1:
                        tareas.Add(LeerTexto("Nueva tarea: "));
                        Console.WriteLine("Tarea agregada.");
                        break;
                    case 2:
                        Mostrar(tareas);
                        break;
                    case 3:
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas para eliminar.");
                        }
                        else
                        {
                            Mostrar(tareas);
                            int numero = LeerNumero("Número de la tarea a eliminar: ", tareas.Count);
                            tareas.Remove(tareas[numero - 1]);
                            Console.WriteLine("Tarea eliminada.");
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Tareas pendientes: {tareas.Count}");
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 5);
        }

        // Muestra las tareas numeradas desde 1
        private void Mostrar(List<string> tareas)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas pendientes.");
            }

            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        //Validacion de entradas no aceptara textos vacios
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
        private int LeerNumero(string mensaje, int maximo)
        {
            Console.Write(mensaje);
            int numero = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            while (numero < 1 || numero > maximo)
            {
                Console.Write($"Inválido, ingrese un número entre 1 y {maximo}: ");
                numero = int.TryParse(Console.ReadLine(), out int m) ? m : 0;
            }

            return numero;
        }
    }
}