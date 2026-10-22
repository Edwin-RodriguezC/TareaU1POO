//Ejercicio #33. Juego de adivinanza
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio33
    {
        public void Ejecutar()
        {
            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 101);
            int maximoIntentos = 7;
            int intentos = 0;
            int pistasMayor = 0;
            int pistasMenor = 0;
            int acertado = 0; // 1 cuando el usuario adivina

            Console.WriteLine("=== Juego de adivinanza ===");
            Console.WriteLine($"Adivine el número entre 1 y 100. Tiene {maximoIntentos} intentos.");

            // Se repite hasta acertar o agotar los intentos
            while (intentos < maximoIntentos && acertado == 0)
            {
                int intento = LeerEnRango($"Intento {intentos + 1} de {maximoIntentos}: ", 1, 100);
                intentos++;

                if (intento == numeroSecreto)
                {
                    acertado = 1;
                }
                else 
                
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Pista: el número es mayor.");
                    pistasMayor++;
                }
                else
                {
                    Console.WriteLine("Pista: el número es menor.");
                    pistasMenor++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(acertado == 1 ? "¡Felicidades, adivinó el número!" : "Se acabaron los intentos, perdió.");

            // Estadísticas finales
            Console.WriteLine("=== Estadísticas ===");
            Console.WriteLine($"Número secreto: {numeroSecreto}");
            Console.WriteLine($"Intentos usados: {intentos}");
            Console.WriteLine($"Intentos restantes: {maximoIntentos - intentos}");
            Console.WriteLine($"Pistas de \"mayor\": {pistasMayor}");
            Console.WriteLine($"Pistas de \"menor\": {pistasMenor}");
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