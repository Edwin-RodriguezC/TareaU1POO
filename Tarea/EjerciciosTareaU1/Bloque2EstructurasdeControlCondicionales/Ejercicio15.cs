//Ejercicio #15: Vocal o consonante
namespace Tarea.EjerciciosTareaU1.Bloque2EstructurasdeControlCondicionales
{
public class Ejercicio15
{
    public void Ejecutar()
    {
        char letra = LeerLetra();

        // En minusculas
        switch (char.ToLower(letra))//Pongo el ToLower para que no tenga problemas con mayúsculas
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'á':
            case 'é':
            case 'í':
            case 'ó':
            case 'ú':
                Console.WriteLine($"'{letra}' es una vocal");
                break;
            default:
                Console.WriteLine($"'{letra}' es una consonante");
                break;
        }
    }
// Validacion de entradas
    private char LeerLetra()
    {
        char letra;
        Console.Write("Ingrese una letra: ");
        while (!char.TryParse(Console.ReadLine(), out letra) || !char.IsLetter(letra))
            Console.Write("Inválido, ingrese una sola letra: ");
        return letra;
    }
}
}