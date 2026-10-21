//Ejercicio #5: Conversion de temperatura
namespace Tarea.VariablesyOperadores
{
        public class Conversiondetemperatura
    {
        public void Convertir()
        {
            Console.WriteLine("Seleccione la conversión de temperatura:");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Celsius a Kelvin");
            Console.WriteLine("3. Fahrenheit a Celsius");
            Console.WriteLine("4. Fahrenheit a Kelvin");
            Console.WriteLine("5. Kelvin a Celsius");
            Console.WriteLine("6. Kelvin a Fahrenheit");
            Console.Write("Ingrese el número de la conversión: ");
            int opcion = LeerOpcion(1, 6);

            switch (opcion)
            {
                case 1:
                    double c1 = LeerTemperatura("Ingrese la temperatura en Celsius: ", -273.15);
                    Console.WriteLine($"{c1} C = {(c1 * 9 / 5) + 32:F2} °F");
                    break;
                case 2:
                    double c2 = LeerTemperatura("Ingrese la temperatura en Celsius: ", -273.15);
                    Console.WriteLine($"{c2} C = {c2 + 273.15:F2} K");
                    break;
                case 3:
                    double f1 = LeerTemperatura("Ingrese la temperatura en Fahrenheit: ", -459.67);
                    Console.WriteLine($"{f1} F = {(f1 - 32) * 5 / 9:F2} °C");
                    break;
                case 4:
                    double f2 = LeerTemperatura("Ingrese la temperatura en Fahrenheit: ", -459.67);
                    Console.WriteLine($"{f2} F = {((f2 - 32) * 5 / 9) + 273.15:F2} K");
                    break;
                case 5:
                    double k1 = LeerTemperatura("Ingrese la temperatura en Kelvin: ", 0);
                    Console.WriteLine($"{k1} K = {k1 - 273.15:F2} °C");
                    break;
                case 6:
                    double k2 = LeerTemperatura("Ingrese la temperatura en Kelvin: ", 0);
                    Console.WriteLine($"{k2} K = {((k2 - 273.15) * 9 / 5) + 32:F2} °F");
                    break;
            }
        }

        // Lee un entero dentro de un rango (para el menú)
        private int LeerOpcion(int min, int max)
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
                Console.Write($"Inválido, ingrese un número entre {min} y {max}: ");
            return valor;
        }

        // Lee una temperatura y valida que no esté por debajo del cero absoluto
        private double LeerTemperatura(string mensaje, double minimo)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || valor < minimo)
                Console.Write($"Inválido, ingrese un número mayor o igual a {minimo}: ");
            return valor;
        }
    
    }
}