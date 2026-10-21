//Ejercicio #4: Área y perímetro
namespace Tarea.EjerciciosTareaU1.Bloque1VariablesyOperadores
{public class Ejercicio04
    {
        public void Calcular()
        {
            Console.WriteLine("Seleccione la figura para calcular área y perímetro:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Trapecio");
            Console.Write("Ingrese el número de la figura: ");
            int opcion = LeerEntero();

            switch (opcion)
            {
                case 1:
                    CalcularCirculo();
                    break;
                case 2:
                    CalcularTriangulo();
                    break;
                case 3:
                    CalcularRectangulo();
                    break;
                case 4:
                    CalcularTrapecio();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private void CalcularCirculo()
        {
            double radio = LeerPositivo("Ingrese el radio: ");

            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;

            MostrarResultado(area, perimetro);
        }

        private void CalcularTriangulo()
        {
            double baseTriangulo = LeerPositivo("Ingrese la base: ");
            double altura = LeerPositivo("Ingrese la altura: ");
            double lado2 = LeerPositivo("Ingrese el segundo lado: ");
            double lado3 = LeerPositivo("Ingrese el tercer lado: ");

            double area = baseTriangulo * altura / 2;
            double perimetro = baseTriangulo + lado2 + lado3;

            MostrarResultado(area, perimetro);
        }

        private void CalcularRectangulo()
        {
            double largo = LeerPositivo("Ingrese el largo: ");
            double ancho = LeerPositivo("Ingrese el ancho: ");

            double area = largo * ancho;
            double perimetro = 2 * (largo + ancho);

            MostrarResultado(area, perimetro);
        }

        private void CalcularTrapecio()
        {
            double baseMayor = LeerPositivo("Ingrese la base mayor: ");
            double baseMenor = LeerPositivo("Ingrese la base menor: ");
            double altura = LeerPositivo("Ingrese la altura: ");
            double ladoA = LeerPositivo("Ingrese el primer lado no paralelo: ");
            double ladoB = LeerPositivo("Ingrese el segundo lado no paralelo: ");

            double area = (baseMayor + baseMenor) * altura / 2;
            double perimetro = baseMayor + baseMenor + ladoA + ladoB;

            MostrarResultado(area, perimetro);
        }

        private void MostrarResultado(double area, double perimetro)
        {
            Console.WriteLine($"Área: {area:F2}");
            Console.WriteLine($"Perímetro: {perimetro:F2}");
        }

        // Validacion para el menu
        private int LeerEntero()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                Console.Write("Inválido, ingrese un valor entero positivo: ");
            return valor;
        }
        
        // Validacion para las dimensiones 
        private double LeerPositivo(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                Console.Write("Inválido, ingrese un valor positivo: ");
            return valor;
        }
    }
}