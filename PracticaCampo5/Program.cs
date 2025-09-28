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

            //hecho por lucinda

            double largo = 10;
            double ancho = 5;
            double area = 0;
            double perimetro = 0;

            // Llamamos a una función que modifica 'area' y 'perimetro' por referencia
            funcionLucinda.CalcularRectangulo(largo, ancho, ref area, ref perimetro);

            Console.WriteLine($"Largo: {largo}, Ancho: {ancho}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");

            // Caso 5: (André) Eliminar DNI por valor
            Console.WriteLine("\n[CASO 5] Ingresa un DNI para eliminarlo:");
            string dniActual = Console.ReadLine();
            string dniEliminado = Operaciones.EliminarDniValor(dniActual);
            Console.WriteLine("Se eliminó correctamente su DNI.");
            Console.WriteLine("\nEstado: " + dniEliminado);

            // Caso 6: (André) Generar DNI por referencia
            Console.WriteLine("\n[CASO 6] Generar un nuevo DNI:");
            Console.WriteLine("Ingrese su numero de DNI");
            string dni1 = Console.ReadLine();
            Console.WriteLine("DNI no reconocido");
            Console.WriteLine("\nGenerando nuevo DNI....");
            string nuevoDni = Operaciones.GenerarDniReferencia(ref dni1);
            Console.WriteLine("\nDNI generado correctamente.");
            Console.WriteLine("Nuevo DNI: " + dni1);

            // Mostrar pie de página
            Operaciones.MostrarPiePagina();

            Console.ReadKey();
        }
    }
}
