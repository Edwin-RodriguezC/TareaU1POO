//Ejercicio #31. MCD y MCM
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio31
    {
        public void Mostrar()
        {
            // Límite de 10000 para el MCM 
            int numero1 = LeerEnRango("Ingrese el primer número entero positivo (1 a 10000): ", 1, 10000);
            int numero2 = LeerEnRango("Ingrese el segundo número entero positivo (1 a 10000): ", 1, 10000);

            int mcd = CalcularMcd(numero1, numero2);
            int mcm = CalcularMcm(numero1, numero2, mcd);

            Console.WriteLine($"MCD({numero1}, {numero2}) = {mcd}");
            Console.WriteLine($"MCM({numero1}, {numero2}) = {mcm}");
        }
        private int CalcularMcd(int a, int b)
        {
            while (b != 0)
            {
                int residuo = a % b;
                a = b;
                b = residuo;
            }

            return a;
        }

        // MCM = (a * b) / MCD
        private int CalcularMcm(int a, int b, int mcd)
        {
            return a / mcd * b;
        }
        private int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
                Console.Write("Inválido, ingrese un número entero: ");
            return valor;
        }
//Validacion de entradas
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