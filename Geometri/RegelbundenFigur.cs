using System;

namespace Geometri
{
    /// <summary>
    /// Abstrakt klass som beskriver en regelbunden tvådimensionell figur. 
    /// Regelbunden innebär att alla sidor är lika långa.
    /// </summary>
    abstract class RegelbundenFigur
    { 
        protected int antalSidor;
        protected double sidlängd;

        //Beräknar figurens omkrets
        public double Omkrets()
        {
            return antalSidor * sidlängd;
        }

        //Beräknar figurens area. En abstrakt metod kräver att alla subklasser implementerar metoden, med samma returvärde och parametrar.
        public abstract double Area();
    }

}
