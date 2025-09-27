using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCampo5
{
    public static class funcionLucinda
    {
        public static void CalcularRectangulo(double largo, double ancho, ref double area, ref double perimetro)
        {
            // Usamos otra función propia para calcular el área
            area = CalcularArea(largo, ancho);

            // Y aquí directamente calculamos el perímetro
            perimetro = 2 * (largo + ancho);
        }

        // Función con encabezado propio que devuelve el área (uso de return por valor)
        public static double CalcularArea(double largo, double ancho)
        {
            return largo * ancho;
        }
    }
}
