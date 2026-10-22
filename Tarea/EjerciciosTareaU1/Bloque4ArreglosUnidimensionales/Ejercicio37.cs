//Ejercicio #37: Registro de números
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio37
    {
        public void Concretar()
        {
            int cantidad = LeerEnRango("¿Cuántos números desea registrar? (1 a 100): ", 1, 100);
            int[] numeros = new int[cantidad];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = LeerEntero($"Número {i + 1}: ");
            }

            //Aqui la suma es doble
            double suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            double promedio = suma / numeros.Length;

            int mayor = numeros[0];
            int menor = numeros[0];
            foreach (int numero in numeros)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Valor mayor: {mayor}");
            Console.WriteLine($"Valor menor: {menor}");
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