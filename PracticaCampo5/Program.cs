using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCampo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar Encabezado
            Operaciones.MostrarEncabezado();

            // Caso 1: Por valor (número al cuadrado)
            Console.WriteLine("\n[CASO 1] Ingresa un número para calcular su cuadrado:");
            int numero = int.Parse(Console.ReadLine()); 
            int cuadrado = Operaciones.Cuadrado(numero);
            Console.WriteLine("El cuadrado es: " + cuadrado);
            Console.WriteLine("El número sigue siendo: " + numero);

            // Caso 2: Por referencia (incremento)
            Console.WriteLine("\n[CASO 2] Ingresa un número para incrementarlo en 1:");
            int valor = int.Parse(Console.ReadLine());
            Operaciones.Incrementar(ref valor);
            Console.WriteLine("Número después del incremento: " + valor);

            // Caso 3: Concatenar nombres (por valor)
            Console.WriteLine("\n[CASO 3] Ingresa el primer nombre:");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingresa el segundo nombre:");
            string nombre2 = Console.ReadLine();
            string resultado = Operaciones.ConcatenarNombres(nombre1, nombre2);
            Console.WriteLine("Resultado: " + resultado);

            // Caso 4: Modificar un nombre por referencia
            Console.WriteLine("\n[CASO 4] Ingresa un nombre:");
            string alumno = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo nombre:");
            string nuevoNombre = Console.ReadLine();
            Operaciones.CambiarNombre(ref alumno, nuevoNombre);
            Console.WriteLine("Nombre después: " + alumno);

            // Mostrar pie de página
            Operaciones.MostrarPiePagina();

            Console.ReadKey();
        }
    }
}
