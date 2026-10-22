//Ejercicio #30. Factorial
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio30
    {
        public void Ejecutar()
        {
            int n = LeerEnRango("Ingrese n (0 a 12): ", 0, 12);
            Console.WriteLine($"{n}! = {Factorial(n)}");

            int r = LeerEnRango($"Ingrese r (0 a {n}): ", 0, n);


            int combinaciones = Factorial(n) / (Factorial(r) * Factorial(n - r));
            Console.WriteLine($"C({n},{r}) = {combinaciones}");
        }

        // Calcula el factorial
        private int Factorial(int numero)
        {
            int resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

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