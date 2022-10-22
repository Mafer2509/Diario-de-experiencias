using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_MFAM_1123122
{
    internal class Triangulorectangulo
    {
        public double catetoA;
        public double anguloOpuestoA;

        public double ObtenerCatetoB()
        {
            return Math.Round (catetoA / Math.Tan (anguloOpuestoA), 3); 
            
            // tan(anguloOpuestoA)=CatA/CatB _ catB = catA/tan(anguloOpuestoA)
        }

        public double ObtenerHipotenusa()
        {
            //sin(angA) = catA/hipotenusa _ hipotenusas = catA / sin(angA)
            return Math.Round (catetoA / Math.Sin(anguloOpuestoA), 3);
        }

        public double ObtenerAnguloOpuesto ()
        {
            // angB + angA = 90 _ angB = 90 -angA
            return 90 - anguloOpuestoA;
        }

        public double ObtenerArea()
        {
            return Math.Round (catetoA * ObtenerCatetoB() / 2, 3);

        }
    }
}
