//Ejercicio #32. Números primos en rango
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio32
    {
        public void Ejecutar()
        {
            // Límite de 1,000,000 
            int inicio = LeerEnRango("Ingrese el inicio del rango (0 a 1000000): ", 0, 1000000);
            int fin = LeerEnRango($"Ingrese el fin del rango ({inicio} a 1000000): ", inicio, 1000000);

            int cantidad = 0;

            Console.WriteLine($"Números primos entre {inicio} y {fin}:");

            for (int numero = inicio; numero <= fin; numero++)
            {
                if (EsPrimo(numero) == 1)
                {
                    Console.Write($"{numero} ");
                    cantidad++;
                }
            }

            Console.WriteLine();

            if (cantidad == 0)
            {
                Console.WriteLine("No hay números primos en el rango.");
            }
            else
            {
                Console.WriteLine($"Cantidad de números primos: {cantidad}");
            }
        }

        // Aqui con los if devuelve 1 si el número es primo y 0 si no lo es
        private int EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return 0;
            }

            for (int divisor = 2; divisor * divisor <= numero; divisor++)
            {
                if (numero % divisor == 0)
                {
                    return 0;
                }
            }

            return 1;
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