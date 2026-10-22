//Ejercicio #39: Estadísticas de calificaciones
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio39
    {
        public void Concretar() 
        {
            int cantidad = LeerEnRango("¿Cuántas calificaciones desea ingresar? (1 a 50): ", 1, 50);
            double[] calificaciones = new double[cantidad];

            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = LeerDoubleEnRango($"Calificación {i + 1} (0 a 100): ", 0, 100);
            }

            double notaAprobacion = 60; // se aprueba con 60 o más
            double suma = 0;
            double maxima = calificaciones[0];
            double minima = calificaciones[0];
            int aprobados = 0;
            int reprobados = 0;

            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;

                if (calificacion > maxima)
                {
                    maxima = calificacion;
                }
                if (calificacion < minima)
                {
                    minima = calificacion;
                }

                if (calificacion >= notaAprobacion)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            double promedio = suma / calificaciones.Length;

            double sumaCuadrados = 0;
            foreach (double calificacion in calificaciones)
            {
                double diferencia = calificacion - promedio;
                sumaCuadrados += diferencia * diferencia;
            }
            double desviacion = Math.Sqrt(sumaCuadrados / calificaciones.Length);

            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Máxima: {maxima:F2}");
            Console.WriteLine($"Mínima: {minima:F2}");
            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Reprobados: {reprobados}");
            Console.WriteLine($"Desviación estándar: {desviacion:F2}");
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