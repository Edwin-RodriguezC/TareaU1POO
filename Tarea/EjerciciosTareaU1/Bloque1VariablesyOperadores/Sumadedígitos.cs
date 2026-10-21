//Ejercicio #6: Suma de dígitos
namespace Tarea.VariablesyOperadores
{
    public class Sumadedígitos
    {
        public void Suma()
        {
            int numero = LeerTresDigitos("Ingrese un número de tres dígitos: ");

            int unidades = numero % 10;        
            int decenas = (numero / 10) % 10;  
            int centenas = numero / 100;       

            int suma = centenas + decenas + unidades;

            Console.WriteLine($"Dígitos: {centenas}, {decenas}, {unidades}");
            Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");
        }

        private int LeerTresDigitos(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor < 100 || valor > 999)
                Console.Write("Inválido, ingrese un número entre 100 y 999: ");
            return valor;
        }
    }
}