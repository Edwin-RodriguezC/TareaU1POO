// Ejercicio #9: Cálculo de salarios semanales
namespace Tarea.VariablesyOperadores
{
    public class SalarioSemanal
    {
        public void Calcular()
        {
            double horas = Leer("Ingrese las horas trabajadas: ");
            double tarifa = Leer("Ingrese la tarifa por hora: ");

            // Si pasa de 44, se calculan normales y extras
            double normales = horas > 44 ? 44 : horas;
            double extras = horas > 44 ? horas - 44 : 0;

            double pagoNormal = normales * tarifa;
            double pagoExtra = extras * (tarifa * 1.5); 
            double total = pagoNormal + pagoExtra;

            Console.WriteLine($"\n Desglose ");
            Console.WriteLine($"Horas normales ({normales} hrs): L. {pagoNormal}");
            Console.WriteLine($"Horas extras ({extras} hrs): L. {pagoExtra}");
            Console.WriteLine($"Total a pagar: L. {total}");
        }

        // Validacion de entradas
        private double Leer(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Console.Write("Inválido. Intente de nuevo: ");
            }
            return valor;
        }
    }
}
