//Ejercicio #27: Inversión de número
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio27
    {
        public void Ejecutar()
        {
            int numero = LeerEntero("Ingrese un número entero: ");

            int invertido = InvertirNumero(numero);

            // Si el número es negativo el numero inverso tambien sera negativo
            if (numero < 0)
            {
                invertido = -invertido;
            }

            Console.WriteLine($"El número invertido es: {invertido}");

            // Es palíndromo si el número y su inverso son iguales
            if (numero == invertido)
            {
                Console.WriteLine($"El número {numero} es palíndromo (capicúa)");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es palíndromo");
            }
        }

        private int InvertirNumero(int numero)
        {
            int restante = numero < 0 ? -numero : numero;
            int invertido = 0;

            // Con el 0 no se ejecutara
            while (restante > 0)
            {
                int digito = restante % 10;           
                invertido = invertido * 10 + digito;  // aca se agrega el inverso
                restante = restante / 10;             
            }

            return invertido;
        }
//Validación de números
        private int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
                Console.Write("Inválido, ingrese un número entero: ");
            return valor;
        }
    }
}