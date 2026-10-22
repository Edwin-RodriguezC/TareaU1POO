//Ejercicio #34: Validación de contraseña
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos
{
    public class Ejercicio34
    {
        public void Realizar()
        {
            int faltantes = 1;
            int intentos = 0;

            while (faltantes > 0)
            {
                Console.Write("Ingrese una contraseña: ");
                string contrasena = Console.ReadLine() ?? "";
                intentos++;

                int mayusculas = 0;
                int minusculas = 0;
                int numeros = 0;
                int especiales = 0;

                // Se revisa cada carácter y se cuenta de qué tipo es
                foreach (char caracter in contrasena)
                {
                    if (char.IsUpper(caracter))
                    {
                        mayusculas++;
                    }
                    else 
                    if (char.IsLower(caracter))
                    {
                        minusculas++;
                    }
                    else 
                    if (char.IsDigit(caracter))
                    {
                        numeros++;
                    }
                    else 
                    if (!char.IsWhiteSpace(caracter))
                    {
                        especiales++;
                    }
                }
                faltantes = 0;

                if (contrasena.Length < 8)
                {
                    Console.WriteLine($"- Faltan {8 - contrasena.Length} caracteres (mínimo 8)");
                    faltantes++;
                }
                if (mayusculas == 0)
                {
                    Console.WriteLine("- Falta al menos una letra mayúscula");
                    faltantes++;
                }
                if (minusculas == 0)
                {
                    Console.WriteLine("- Falta al menos una letra minúscula");
                    faltantes++;
                }
                if (numeros == 0)
                {
                    Console.WriteLine("- Falta al menos un número");
                    faltantes++;
                }
                if (especiales == 0)
                {
                    Console.WriteLine("- Falta al menos un carácter especial");
                    faltantes++;
                }
            }

            Console.WriteLine($"Contraseña válida. Intentos usados: {intentos}");
        }
    }
}