using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifca_Montella
{
    public class Quadrato : FiguraGeometrica
    {
        public double Lato { get; set; }
        public Quadrato(double lato, double v) : base(v)
        {
            Lato = lato;
        }

        public override string GetDescrizione() => "Figura Quadrato" +
            $"\nValore: {valore}";
        public override double GetPerimetro() => Lato * 4;
        public override double GetArea() => Lato * Lato;
        
    }
}
