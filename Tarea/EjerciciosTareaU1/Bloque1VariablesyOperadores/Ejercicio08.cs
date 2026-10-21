// Ejercicio #8: Desglose de billetes
namespace Tarea.EjerciciosTareaU1.Bloque1VariablesyOperadores
{
    
    public class Ejercicio08
    {
        public void Calcular()
        {
            int monto = LeerMonto("Ingrese el monto en lempiras: ");

            // lista en orden  de mayor a menor
            int[] billetes ={500, 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("\nDesglose de billetes necesarios:");

            foreach (int billete in billetes)
            {
                int cantidad = monto / billete; 

                if (cantidad > 0)
                {
                    Console.WriteLine($"Billetes de L. {billete}: {cantidad}");
                    monto = monto % billete; //Lo que sobra
                }
            }
        }
// Validacion de entradas
        private int LeerMonto(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Inválido. Ingrese un monto entero positivo: ");
            }
            return valor;
        }
    }
}