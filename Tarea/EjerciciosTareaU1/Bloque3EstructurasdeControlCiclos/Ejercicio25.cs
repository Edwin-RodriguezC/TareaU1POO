//Ejercicio #25: Promedio con centinela
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio25
    {
        public void Ejecutar()
        {
            double suma = 0;
            int cantidad = 0;
            double maximo = 0;
            double minimo = 0;

            double numero = LeerNumero("Ingrese un número (-1 para terminar): ");

            // -1 es el centinela
            while (numero != -1)
            {
                if (cantidad == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }
                suma += numero;
                cantidad++;

                numero = LeerNumero("Ingrese un número (-1 para terminar): ");
            }
            if (cantidad == 0)
            {
                Console.WriteLine("No se ingresaron valores.");
            }
            else
            {
                double promedio = suma / cantidad;
                Console.WriteLine($"Cantidad de valores: {cantidad}");
                Console.WriteLine($"Promedio: {promedio}");
                Console.WriteLine($"Máximo: {maximo}");
                Console.WriteLine($"Mínimo: {minimo}");
            }
        }
        //Validacion de Entradas
        private double LeerNumero(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor))
                Console.Write("Inválido, ingrese un número: ");
            return valor;
        }
    }
}