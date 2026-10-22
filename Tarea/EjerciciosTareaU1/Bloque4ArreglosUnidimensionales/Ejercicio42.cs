//Ejercicio #42: Búsqueda y ordenamiento
namespace Tarea.EjerciciosTareaU1.Bloque4ArreglosUnidimensionales
{
    public class Ejercicio42
    {
        public void Concretar()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = LeerEntero($"Número {i + 1}: ");
            }

            Console.Write("Arreglo ingresado: ");
            MostrarArreglo(numeros);

            //Compara uno por uno
            int buscado = LeerEntero("Ingrese el valor a buscar: ");
            int coincidencias = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine($"El valor {buscado} está en la posición {i}");
                    coincidencias++;
                }
            }

            if (coincidencias == 0)
            {
                Console.WriteLine($"El valor {buscado} no está en el arreglo");
            }

            // el segnudo mayor
            int mayor = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            int haySegundo = 0; // pasa a 1 cuando se encuentra un valor menor al máximo
            int segundoMayor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < mayor && (haySegundo == 0 || numeros[i] > segundoMayor))
                {
                    segundoMayor = numeros[i];
                    haySegundo = 1;
                }
            }

            if (haySegundo == 1)
            {
                Console.WriteLine($"Segundo mayor: {segundoMayor}");
            }
            else
            {
                Console.WriteLine("No hay segundo mayor (todos los valores son iguales)");
            }

            // Ordenamiento
            for (int pasada = 0; pasada < numeros.Length - 1; pasada++)
            {
                for (int j = 0; j < numeros.Length - 1 - pasada; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temporal = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temporal;
                    }
                }
            }

            Console.Write("Arreglo ordenado: ");
            MostrarArreglo(numeros);

            //Ordena por posicion con el for
            Console.WriteLine("Elementos en posiciones pares:");
            for (int i = 0; i < numeros.Length; i += 2)
            {
                Console.WriteLine($"Posición {i}: {numeros[i]}");
            }
        }
//Validacion de entradas
        private void MostrarArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"{arreglo[i]} ");
            }
            Console.WriteLine();
        }

        private int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
                Console.Write("Inválido, ingrese un número entero: ");
            return valor;
        }
    }
}