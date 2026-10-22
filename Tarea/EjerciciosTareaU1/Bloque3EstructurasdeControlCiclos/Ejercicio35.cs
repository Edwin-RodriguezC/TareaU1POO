//Ejercicio #35: Patrones en consola
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio35
    {
        public void Ejecutar()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("1.Triángulo");
                Console.WriteLine("2.Triángulo invertido");
                Console.WriteLine("3.Rombo");
                Console.WriteLine("4.Cuadrado hueco");
                Console.WriteLine("5.Pirámide numérica");
                Console.WriteLine("6.Salir");
                opcion = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

                
                int tamano = 0;
                if (opcion >= 1 && opcion <= 5)
                {
                    tamano = LeerTamano();
                }

                switch (opcion)
                {
                    case 1:
                        Triangulo(tamano);
                        break;
                    case 2:
                        TrianguloInvertido(tamano);
                        break;
                    case 3:
                        Rombo(tamano);
                        break;
                    case 4:
                        CuadradoHueco(tamano);
                        break;
                    case 5:
                        PiramideNumerica(tamano);
                        break;
                    case 6:
                        Console.WriteLine("Saliendo");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 6);
        }
//Validacion de tamaño
        private void Triangulo(int tamano)
        {
            for (int fila = 1; fila <= tamano; fila++)
            {
                for (int col = 1; col <= fila; col++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        private void TrianguloInvertido(int tamano)
        {
            for (int fila = tamano; fila >= 1; fila--)
            {
                for (int col = 1; col <= fila; col++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        // Primero crece y luego decrece
        private void Rombo(int tamano)
        {
            for (int fila = 1; fila <= tamano; fila++)
            {
                Console.WriteLine(new string(' ', tamano - fila) + new string('*', 2 * fila - 1));
            }
            for (int fila = tamano - 1; fila >= 1; fila--)
            {
                Console.WriteLine(new string(' ', tamano - fila) + new string('*', 2 * fila - 1));
            }
        }
        private void CuadradoHueco(int tamano)
        {
            for (int fila = 1; fila <= tamano; fila++)
            {
                for (int col = 1; col <= tamano; col++)
                {
                    if (fila == 1 || fila == tamano || col == 1 || col == tamano)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        private void PiramideNumerica(int tamano)
        {
            for (int fila = 1; fila <= tamano; fila++)
            {
                Console.Write(new string(' ', tamano - fila));
                for (int num = 1; num <= fila; num++)
                    Console.Write(num);
                for (int num = fila - 1; num >= 1; num--)
                    Console.Write(num);
                Console.WriteLine();
            }
        }
        private int LeerTamano()
        {
            Console.Write("Tamaño (1 a 9): ");
            int tamano = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            while (tamano < 1 || tamano > 9)
            {
                Console.Write("Inválido, ingrese un tamaño entre 1 y 9: ");
                tamano = int.TryParse(Console.ReadLine(), out int m) ? m : 0;
            }

            return tamano;
        }
    }
}