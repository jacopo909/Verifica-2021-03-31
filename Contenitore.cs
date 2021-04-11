using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifca_Montella
{
    class Contenitore
    {
        protected List<FiguraGeometrica> FigureGeometriche = new List<FiguraGeometrica>();
        public Contenitore() { }
        public void AggiungiFigura(FiguraGeometrica f) => FigureGeometriche.Add(f);

        public void ElencaFigure()
        {
            foreach(FiguraGeometrica f in FigureGeometriche)
            {
                Console.WriteLine(f.GetDescrizione());
            }
        }
        public void Svuota() => FigureGeometriche.Clear();
        public FiguraGeometrica GetFigura() => FigureGeometriche.First();
    }
}
