using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifca_Montella
{
    class Selettore : Contenitore
    {
        List<FiguraGeometrica> figureSelettore = new List<FiguraGeometrica>();
        PoliticaSelezione p;
        public void Scanzionaselettore(Contenitore c)
        {
            
        }
        public void ImpostaPolitica(PoliticaSelezione politica)
        {
            p = politica;
        }
    }
}
