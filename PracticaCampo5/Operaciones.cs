using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCampo5
{
    public static class Operaciones
    {
        public static void MostrarEncabezado()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("   PROGRAMA DE MÉTODOS EN C#          ");
            Console.WriteLine("   Parámetros por Valor y Referencia  ");
            Console.WriteLine("======================================");
        }
        public static void MostrarPiePagina()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("   Fin del programa. Gracias!         ");
            Console.WriteLine("======================================");
        }

        // Método con parámetro por valor
        public static int Cuadrado(int num)
        {
            return num * num;
        }

        // Método con parámetro por referencia
        public static void Incrementar(ref int num)
        {
            num = num + 1;
        }

        // Método con parámetros por valor
        public static string ConcatenarNombres(string n1, string n2)
        {
            return n1 + " y " + n2;
        }

        // Método con parámetro por referencia (string)
        public static void CambiarNombre(ref string nombre, string nuevo)
        {
            nombre = nuevo;
        }

        //(Andre) Método con parámetros por valor
        public static string EliminarDniValor(string dni)
        {
            dni = "DNI eliminado correctamente";
            return dni;
        }

        //(Andre) Método con parámetros por referencia
        public static string GenerarDniReferencia(ref string dni)
        {
            dni = "01234567";
            return dni;
        }
    }
}
