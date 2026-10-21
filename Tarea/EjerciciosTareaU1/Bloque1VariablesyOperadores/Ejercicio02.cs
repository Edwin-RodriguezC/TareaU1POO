//Ejercicio #2: Calculadora de IMC
namespace Tarea.EjerciciosTareaU1.Bloque1VariablesyOperadores
{
    public class Ejercicio02
    {
        public void CalcularIMC()
        {
            double peso = LeerPositivo("Ingrese su peso en kilogramos: ");
            double altura = LeerPositivo("Ingrese su altura en metros: ");

            double imc = peso / (altura * altura);

            Console.WriteLine($"Su índice de masa corporal (IMC) es: {imc:F2}");
        }

        private double LeerPositivo(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                Console.Write("Inválido, Ingrese un valor positivo: ");
            return valor;
        }                               
    }
}