//Ejercicio #46: Lista de compras
namespace Tarea.EjerciciosTareaU1.Bloque5Listas
{
    public class Ejercicio46
    {
        public void Ejecutar()
        {
            List<string> productos = new List<string>();
            int opcion;

            do
            {
                Console.Clear(); //Para mejorar la presentacion
                Console.WriteLine("1.Agregar producto");
                Console.WriteLine("2.Eliminar producto");
                Console.WriteLine("3.Buscar producto");
                Console.WriteLine("4.Mostrar lista ordenada");
                Console.WriteLine("5.Salir");
                opcion = int.TryParse(Console.ReadLine(), out int o) ? o : 0;

                switch (opcion)
                {
                    case 1:
                        string nuevo = LeerTexto("Producto a agregar: ");

                        if (productos.Contains(nuevo))
                        {
                            Console.WriteLine("Ese producto ya está en la lista.");
                        }
                        else
                        {
                            productos.Add(nuevo);
                            Console.WriteLine("Producto agregado.");
                        }
                        break;
                    case 2:
                        string eliminar = LeerTexto("Producto a eliminar: ");

                        if (productos.Contains(eliminar))
                        {
                            productos.Remove(eliminar);
                            Console.WriteLine("Producto eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("Ese producto no está en la lista.");
                        }
                        break;
                    case 3:
                        string buscado = LeerTexto("Producto a buscar: ");
                        Console.WriteLine(productos.Contains(buscado) ? "Sí está en la lista." : "No está en la lista.");
                        break;
                    case 4:
                        productos.Sort(); // aca lleva orden alfabético
                        Console.WriteLine($"Lista de compras ({productos.Count}):");

                        foreach (string producto in productos)
                        {
                            Console.WriteLine($"- {producto}");
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

        //Validacion de entradas no aceptara textos vacios
        private string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            string texto = (Console.ReadLine() ?? "").Trim().ToLower();

            while (texto == "")
            {
                Console.Write("Inválido, no puede estar vacío: ");
                texto = (Console.ReadLine() ?? "").Trim().ToLower();
            }

            return texto;
        }
    }
}