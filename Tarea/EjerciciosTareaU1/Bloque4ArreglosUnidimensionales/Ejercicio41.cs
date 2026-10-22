//Ejercicio #41: Arreglo de temperaturas
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio41
    {
        public void Concretar()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            double[] temperaturas = new double[7];

            for (int i = 0; i < temperaturas.Length; i++)
            {
                temperaturas[i] = LeerDoubleEnRango($"Temperatura del {dias[i]} (°C): ", -50, 60);
            }

            // Promedio semanal
            double suma = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];
            }
            double promedio = suma / temperaturas.Length;

            // Declaro Dia más caluroso y más frío
            int diaMasCaluroso = 0;
            int diaMasFrio = 0;
            for (int i = 1; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > temperaturas[diaMasCaluroso])
                {
                    diaMasCaluroso = i;
                }
                if (temperaturas[i] < temperaturas[diaMasFrio])
                {
                    diaMasFrio = i;
                }
            }

            Console.WriteLine($"Promedio semanal: {promedio:F2} °C");

            Console.WriteLine("Días sobre el promedio:");
            bool haySobrePromedio = false;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > promedio)
                {
                    Console.WriteLine($"- {dias[i]}: {temperaturas[i]:F2} °C");
                    haySobrePromedio = true;
                }
            }
            if (!haySobrePromedio)
            {
                Console.WriteLine("- Ninguno");
            }

            Console.WriteLine($"Día más caluroso: {dias[diaMasCaluroso]} ({temperaturas[diaMasCaluroso]:F2} °C)");
            Console.WriteLine($"Día más frío: {dias[diaMasFrio]} ({temperaturas[diaMasFrio]:F2} °C)");

            // Variación = temperatura de hoy - temperatura del día anterior
            Console.WriteLine("Variación entre días consecutivos:");
            for (int i = 1; i < temperaturas.Length; i++)
            {
                double variacion = temperaturas[i] - temperaturas[i - 1];
                Console.WriteLine($"{dias[i - 1]} a {dias[i]}: {variacion:F2} °C");
            }
        }
//Validacion de entradas
        private double LeerDouble(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || double.IsNaN(valor) || double.IsInfinity(valor))
                Console.Write("Inválido, ingrese un número: ");
            return valor;
        }

        private double LeerDoubleEnRango(string mensaje, double minimo, double maximo)
        {
            double valor = LeerDouble(mensaje);

            while (valor < minimo || valor > maximo)
            {
                Console.WriteLine($"Fuera de rango, debe estar entre {minimo} y {maximo}.");
                valor = LeerDouble(mensaje);
            }

            return valor;
        }
    }
}