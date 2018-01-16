using System;

namespace Geometri
{
    class Triangel : RegelbundenFigur
    {
        //Lägg till följande i klassen
        //
        //1. Konstruktor som 
        //  a) tar in värde för sidlängd
        //  b) sätter rätt värde för antalSidor
        //
        //2. Implementering av metoden Area(), som alltså ska beräkna figurens area

        //-----------------Din kod här!---------------------------
        
        //Konstruktor
        public Triangel(double sidlängd)
        {
            this.sidlängd = sidlängd;
            antalSidor = 3;
        }

        public override double Area()
        {
            //beräknar arean
            double area = sidlängd * sidlängd * Math.Sqrt(3) / 4;

            //returnerar arean
            return area;
        }



        //--------------------------------------------------------
    }
}
