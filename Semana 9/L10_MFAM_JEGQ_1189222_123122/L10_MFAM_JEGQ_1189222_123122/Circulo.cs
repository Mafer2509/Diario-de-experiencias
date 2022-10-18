using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_MFAM_JEGQ_1189222_123122
{
    internal class Circulo
    {
        double r = 0; 
        public Circulo (double radio)
        {
            r = radio;
        }
        public double ObtenerPerimetro (double p)
        {
            p = 2 * r * 3.14;
            return p;
        }
        public double ObtenerArea (double a)
        {
            a = 3.14 * Math.Pow (r, 2);
            return a;
        }
        public double Obtenervolumen (double v)
        {
            v = 4 / 3 * 3.14 * Math.Pow(r, 3);
            return v;
        }
        public double CalcularGeometria(double g)
        {
            return g;
         }
             
            

    }
}
