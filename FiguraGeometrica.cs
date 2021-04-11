using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifca_Montella
{
    public abstract class FiguraGeometrica
    {
        Contenitore c;
        protected double valore;
        public FiguraGeometrica(double v)
        {
            valore = v;
        }
        public abstract string GetDescrizione();
        public abstract double GetPerimetro();
        public abstract double GetArea();
    }
}
