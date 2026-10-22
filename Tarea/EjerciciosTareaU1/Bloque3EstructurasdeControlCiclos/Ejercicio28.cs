
//Ejercicio #28. Decimal a binario.
namespace Tarea.EjerciciosTareaU1.Bloque3EstructurasdeControlCiclos

{
    public class Ejercicio28
    {
        public void Ejecutar()
        {
            int numero = LeerPositivo("Ingrese un número entero positivo: ");

            string binario = ConvertirABinario(numero);

            Console.WriteLine($"El número {numero} en binario es: {binario}");
        }

        private string ConvertirABinario(int numero)
        {
            string binario = "";

            while (numero > 0)
            {
                int residuo = numero % 2;
                binario = residuo + binario;
                numero = numero / 2;
            }

            return binario;
        }

        //Validacion de entradas
        private int LeerPositivo(string mensaje)
        {
            Console.Write(mensaje);
            int valor = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            while (valor <= 0)
            {
                Console.Write("Inválido, ingrese un número entero positivo: ");
                valor = int.TryParse(Console.ReadLine(), out int m) ? m : 0;
            }

            return valor;
        }
    }
}