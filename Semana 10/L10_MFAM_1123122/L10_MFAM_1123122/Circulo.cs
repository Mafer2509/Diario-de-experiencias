using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_MFAM_1123122
{
    internal class Circulo
    {
        public double radio;

        public double ObtenerPerimetro()
        {
            return 2 * Math.PI *radio;
        }
        public double ObtenerArea()
        {
            return Math.PI * radio;
        }
        public double ObtenerVolumen()
        {
            return 4 * Math.PI * Math.Pow(radio,3) / 3;
        }
        public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
           
            unPerimetro = ObtenerPerimetro();
            unArea = ObtenerArea();
            unVolumen = ObtenerVolumen();

        }
    }
}
