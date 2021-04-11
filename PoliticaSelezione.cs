using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifca_Montella
{
    abstract class PoliticaSelezione
    {
        protected double soglia;
        public PoliticaSelezione(double soglia = 0)
        {
            this.soglia = soglia;
        }
        public abstract bool Selezione(FiguraGeometrica f);
    }
}
