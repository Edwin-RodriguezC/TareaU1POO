// Ejercicio #10: Calculadora de prestamo
namespace Tarea.VariablesyOperadores
{
    public class PrestamoSimple
    {
        public void Calcular()
        {
            double monto = Leer("Ingrese el monto del préstamo en Lempiras: ");
            double tasaAnual = Leer("Ingrese la tasa de interés anual (%): ");
            double meses = Leer("Ingrese el plazo en meses: ");

            // Cálculo del interés total
            double interesTotal = monto * (tasaAnual / 100) * (meses / 12);
            double totalAPagar = monto + interesTotal;
            double cuotaMensual = totalAPagar / meses;

            Console.WriteLine("\n Resumen del Préstamo ");
            Console.WriteLine($"Monto solicitado: L. {monto:F2}");
            Console.WriteLine($"Interés total a pagar: L. {interesTotal:F2}");
            Console.WriteLine($"Total general a pagar: L. {totalAPagar:F2}");
            Console.WriteLine($"Cuota mensual fija: L. {cuotaMensual:F2}");
        }
        // Validacion de entradas
        private double Leer(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Inválido. Ingrese un valor mayor a 0: ");
            }
            return valor;
        }
    }
}