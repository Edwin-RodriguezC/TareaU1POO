//Ejercico #7: Tiempo transcurrido
namespace Tarea.EjerciciosTareaU1.Bloque1VariablesyOperadores
{
    public class Ejercicio07
    {
        public void Calcular()
        {
            Console.WriteLine("Calculo de tiempo transcurrido");

            int segundos1 = LeerHora("primera");
            int segundos2 = LeerHora("segunda");

            int diferencia;

            
            if (segundos2 >= segundos1)
            {
                diferencia = segundos2 - segundos1;
            }
            else
            {
                diferencia = segundos1 - segundos2;
            }

            int horas = diferencia / 3600;
            int minutos = (diferencia % 3600) / 60;
            int segundos = diferencia % 60;

            Console.WriteLine($"\nDiferencia: {horas} horas, {minutos} minutos, {segundos} segundos");
        }
        //Validacion de Entradas
        private int LeerHora(string tipo)
        {
            Console.WriteLine($"Ingrese la {tipo} hora:");
            int hora = LeerEnRango("  Hora (0-23): ", 0, 23);
            int minuto = LeerEnRango("  Minuto (0-59): ", 0, 59);
            int segundo = LeerEnRango("  Segundo (0-59): ", 0, 59);

            return hora * 3600 + minuto * 60 + segundo;
        }

        private int LeerEnRango(string mensaje, int min, int max)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
            {
                Console.Write($"Valor inválido. Ingrese un número entre {min} y {max}: ");
            }
            return valor;
        }
    }
}