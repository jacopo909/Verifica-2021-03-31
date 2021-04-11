using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifca_Montella
{
    class AreaMassima : PoliticaSelezione
    {
        public override bool Selezione(FiguraGeometrica f)
        {
            bool flag = false;
            if(f.GetArea() < soglia)
            {
                flag = true;
            }
            return flag;
            
        }
    }
}
