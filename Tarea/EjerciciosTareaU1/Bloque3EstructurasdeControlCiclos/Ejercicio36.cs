//Ejercicio #36: Números primos en rango
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio36
    {
        public void Calcular()
        {
            double resultado = 0;
            int hayResultado = 0; // 1 si ya hay un resultado para encadenar
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== CALCULADORA ===");

                if (hayResultado == 1)
                {
                    Console.WriteLine($"Resultado actual: {resultado:F2}");
                }

                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Restar");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Dividir");
                Console.WriteLine("5.Potencia");
                Console.WriteLine("6.Raíz cuadrada");
                Console.WriteLine("7.Porcentaje");
                Console.WriteLine("8.Limpiar resultado");
                Console.WriteLine("9.Salir");
                opcion = LeerEntero("Seleccione una opción: ");

                double primero = 0;
                double segundo = 0;
                double potencia;

                switch (opcion)
                {
                    case 1:
                        primero = ObtenerPrimerNumero(hayResultado, resultado);
                        segundo = LeerDouble("Segundo número: ");
                        resultado = primero + segundo;
                        hayResultado = 1;
                        Console.WriteLine($"{primero:F2} + {segundo:F2} = {resultado:F2}");
                        break;
                    case 2:
                        primero = ObtenerPrimerNumero(hayResultado, resultado);
                        segundo = LeerDouble("Segundo número: ");
                        resultado = primero - segundo;
                        hayResultado = 1;
                        Console.WriteLine($"{primero:F2} - {segundo:F2} = {resultado:F2}");
                        break;
                    case 3:
                        primero = ObtenerPrimerNumero(hayResultado, resultado);
                        segundo = LeerDouble("Segundo número: ");
                        resultado = primero * segundo;
                        hayResultado = 1;
                        Console.WriteLine($"{primero:F2} * {segundo:F2} = {resultado:F2}");
                        break;
                    case 4:
                        primero = ObtenerPrimerNumero(hayResultado, resultado);
                        segundo = LeerDouble("Divisor: ");

                        if (segundo == 0)
                        {
                            Console.WriteLine("Error: no se puede dividir entre cero.");
                        }
                        else
                        {
                            resultado = primero / segundo;
                            hayResultado = 1;
                            Console.WriteLine($"{primero:F2} / {segundo:F2} = {resultado:F2}");
                        }
                        break;
                    case 5:
                        primero = ObtenerPrimerNumero(hayResultado, resultado);
                        segundo = LeerDouble("Exponente: ");
                        potencia = Math.Pow(primero, segundo);

                        if (double.IsNaN(potencia) || double.IsInfinity(potencia))
                        {
                            Console.WriteLine("Error: la operación no tiene un resultado válido.");
                        }
                        else
                        {
                            resultado = potencia;
                            hayResultado = 1;
                            Console.WriteLine($"{primero:F2} ^ {segundo:F2} = {resultado:F2}");
                        }
                        break;
                    case 6:
                        primero = ObtenerPrimerNumero(hayResultado, resultado);

                        if (primero < 0)
                        {
                            Console.WriteLine("Error: no existe la raíz cuadrada de un número negativo.");
                        }
                        else
                        {
                            resultado = Math.Sqrt(primero);
                            hayResultado = 1;
                            Console.WriteLine($"Raíz cuadrada de {primero:F2} = {resultado:F2}");
                        }
                        break;
                    case 7:
                        primero = ObtenerPrimerNumero(hayResultado, resultado);
                        segundo = LeerDouble("Porcentaje a calcular (%): ");
                        resultado = primero * segundo / 100;
                        hayResultado = 1;
                        Console.WriteLine($"{segundo:F2}% de {primero:F2} = {resultado:F2}");
                        break;
                    case 8:
                        resultado = 0;
                        hayResultado = 0;
                        Console.WriteLine("Resultado limpiado.");
                        break;
                    case 9:
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                if (opcion != 9)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 9); //Se sale de la calculadora
        }

        //Validaciones de entradas
        private double ObtenerPrimerNumero(int hayResultado, double resultado)
        {
            if (hayResultado == 1)
            {
                Console.Write($"¿Usar el resultado anterior ({resultado:F2}) como primer número? (s/n): ");
                string respuesta = (Console.ReadLine() ?? "").Trim().ToLower();

                if (respuesta == "s")
                {
                    return resultado;
                }
            }

            return LeerDouble("Primer número: ");
        }

        private int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
                Console.Write("Inválido, ingrese un número entero: ");
            return valor;
        }

        private double LeerDouble(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || double.IsNaN(valor) || double.IsInfinity(valor))
                Console.Write("Inválido, ingrese un número: ");
            return valor;
        }
    }
}