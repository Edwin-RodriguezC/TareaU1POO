//Ejercicio #50: Registro de estudiantes
namespace Tarea.EjerciciosTareaU1.Bloque5Listas
{
    public class Ejercicio50
    {
        public void Ejecutar()
        {
            //La posicion del promedio es el indice del nombre
            List<string> nombres = new List<string>();
            List<double> promedios = new List<double>();
            int opcion;

            do
            {
                Console.Clear();// Para mejorar la presentacion
                Console.WriteLine("1.Agregar estudiante");
                Console.WriteLine("2.Buscar por nombre");
                Console.WriteLine("3.Mejor promedio");
                Console.WriteLine("4.Listado general");
                Console.WriteLine("5.Salir");
                opcion = int.TryParse(Console.ReadLine(), out int o) ? o : 0;

                switch (opcion)
                {
                    case 1:
                        nombres.Add(LeerTexto("Nombre: "));
                        promedios.Add(LeerPromedio());
                        Console.WriteLine("Estudiante agregado.");
                        break;
                    case 2:
                        string buscado = LeerTexto("Nombre a buscar: ");
                        int encontrados = 0;

                        for (int i = 0; i < nombres.Count; i++)
                        {
                            if (nombres[i].ToLower() == buscado.ToLower())
                            {
                                Console.WriteLine($"{nombres[i]} - Promedio: {promedios[i]:F2}");
                                encontrados++;
                            }
                        }

                        if (encontrados == 0)
                        {
                            Console.WriteLine("No se encontró ese estudiante.");
                        }
                        break;
                    case 3:
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados.");
                        }
                        else
                        {
                            // Guarda la posicion del mejor promedio
                            int mejor = 0;
                            for (int i = 1; i < promedios.Count; i++)
                            {
                                if (promedios[i] > promedios[mejor])
                                {
                                    mejor = i;
                                }
                            }
                            Console.WriteLine($"Mejor promedio: {nombres[mejor]} con {promedios[mejor]:F2}");
                        }
                        break;
                    case 4:
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados.");
                        }

                        for (int i = 0; i < nombres.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {nombres[i]} - Promedio: {promedios[i]:F2}");
                        }
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

        // Validacion de entradas no acepta textos vacíos
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
        private double LeerPromedio()
        {
            Console.Write("Promedio (0 a 100): ");
            double promedio = double.TryParse(Console.ReadLine(), out double n) ? n : -1;

            while (!(promedio >= 0 && promedio <= 100))
            {
                Console.Write("Inválido, ingrese un promedio entre 0 y 100: ");
                promedio = double.TryParse(Console.ReadLine(), out double m) ? m : -1;
            }

            return promedio;
        }
    }
}