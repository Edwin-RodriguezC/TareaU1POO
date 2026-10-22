//Ejercicio #43: Rotación de arreglo
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio43
    {
        public void Concretar()
        {
            Console.Write("Cantidad de elementos: ");
            int cantidad = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            while (cantidad < 1)
            {
                Console.Write("Inválido, ingrese un número mayor a 0: ");
                cantidad = int.TryParse(Console.ReadLine(), out int m) ? m : 0;
            }

            int[] arreglo = new int[cantidad];

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                arreglo[i] = int.TryParse(Console.ReadLine(), out int e) ? e : 0;
            }

            int opcion;

            do
            {
                Console.Clear();
                Mostrar(arreglo);
                Console.WriteLine("1.Rotar a la izquierda");
                Console.WriteLine("2.Rotar a la derecha");
                Console.WriteLine("3.Invertir");
                Console.WriteLine("4.Salir");
                opcion = int.TryParse(Console.ReadLine(), out int o) ? o : 0;

                switch (opcion)
                {
                    case 1:
                        RotarIzquierda(arreglo, LeerK());
                        break;
                    case 2:
                        // Rotar K a la derecha es lo mismo que rotar (tamaño - K) a la izquierda
                        RotarIzquierda(arreglo, arreglo.Length - LeerK() % arreglo.Length);
                        break;
                    case 3:
                        Invertir(arreglo);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                if (opcion >= 1 && opcion <= 3)
                {
                    Console.Write("Resultado: ");
                    Mostrar(arreglo);
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 4);
        }

        // Cada vuelta mueve los elementos una posición a la izquierda
        private void RotarIzquierda(int[] arreglo, int k)
        {
            for (int vuelta = 0; vuelta < k % arreglo.Length; vuelta++)
            {
                int primero = arreglo[0];

                for (int i = 0; i < arreglo.Length - 1; i++)
                    arreglo[i] = arreglo[i + 1];

                arreglo[arreglo.Length - 1] = primero;
            }
        }

        // Se intercambian los extremos hasta llegar a la mitad
        private void Invertir(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length / 2; i++)
            {
                int temporal = arreglo[i];
                arreglo[i] = arreglo[arreglo.Length - 1 - i];
                arreglo[arreglo.Length - 1 - i] = temporal;
            }
        }

        private void Mostrar(int[] arreglo)
        {
            foreach (int numero in arreglo)
                Console.Write($"{numero} ");
            Console.WriteLine();
        }

        // K no puede ser negativo
        private int LeerK()
        {
            Console.Write("Posiciones (K): ");
            int k = int.TryParse(Console.ReadLine(), out int n) ? n : -1;

            while (k < 0)
            {
                Console.Write("Inválido, ingrese K mayor o igual a 0: ");
                k = int.TryParse(Console.ReadLine(), out int m) ? m : -1;
            }

            return k;
        }
    }
}