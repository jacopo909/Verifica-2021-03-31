﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifca_Montella
{
    public class Cerchio : FiguraGeometrica
    {
        public double Raggio { get; set; }
        public Cerchio(double raggio, double v) : base(v)
        {
            Raggio = raggio;   
        }

        public override string GetDescrizione() => "Figura Cerchio" +
            $"\nValore: {valore}";
        public override double GetPerimetro() => Raggio += Math.PI;
        public override double GetArea() => (Raggio * Raggio) * Math.PI;
        
    }
}
