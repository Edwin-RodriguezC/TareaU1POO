//Ejercicio #26:Potencia con ciclo
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio26
    {
        public void Ejecutar()
        {
            double baseNumero = LeerDouble("Ingrese la base: "); //double porque pide el resultado en decimales
            int exponente = LeerEntero("Ingrese el exponente (entero): ");

            if (baseNumero == 0 && exponente < 0)
            {
                Console.WriteLine("Error: no se puede elevar 0 a un exponente negativo.");
            }
            else
            {
                double resultado = CalcularPotencia(baseNumero, exponente);
                Console.WriteLine($"{baseNumero} elevado a {exponente} = {resultado:F2}");
            }
        }
        private double CalcularPotencia(double baseNumero, int exponente)
        {
            // Con exponente 0 no se ejecutara
            double resultado = 1;

            //Cantidad de multiplicaciones
            int veces = exponente < 0 ? -exponente : exponente;

            for (int i = 0; i < veces; i++)
            {
                resultado = resultado * baseNumero;
            }

            // Si el exponente es negativo, se va a invertir segun reglas de matematicas
            if (exponente < 0)
            {
                resultado = 1 / resultado;
            }

            return resultado;
        }

        private double LeerDouble(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor))
                Console.Write("Inválido, ingrese un número: ");
            return valor;
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
    }
}