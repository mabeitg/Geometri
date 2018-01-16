using System;

namespace Geometri
{
    class Kvadrat : RegelbundenFigur
    {
        //Lägg till följande i klassen
        //
        //1. Konstruktor som 
        //  a) tar in värde för sidlängd
        //  b) sätter rätt värde för antalSidor
        //
        //2. Implementering av metoden Area(), som alltså ska beräkna figurens area 
        //
        //3. Egenskaper/Properties för antalSidor(bara get) och sidlängd (både get och set)
        //
        //4. En metod Draw(), som ritar ut en kvadrat av rätt storlek i Console.
        //   Om sidlängd är mindre än 1.5 ska inget ritas utan metoden ska i stället
        //   kasta ett undantag med meddelandet "För liten för att ritas!"

        //-----------------Din kod här!---------------------------

        //Konstruktor
        public Kvadrat(double sidlängd)
        {
            this.sidlängd = sidlängd;
            antalSidor = 4;
        }

        public override double Area()
        {
            return sidlängd * sidlängd;
        }


        //---Egenskaper/Properties. Ser du att de börjar med stor bokstav? Gör så du också!---

        public int AntalSidor
        {
            get
            {
                return antalSidor;
            }
        }

        public double Sidlängd
        {
            get
            {
                return sidlängd;
            }
            set
            {
                sidlängd = value;
            }
        }

        public void Draw()
        {
            if (sidlängd < 1.5)
                throw new Exception("För liten för att ritas!");

            else
            {   
                //Avrundar sidlängd till närmsta heltal
                double avrundadSidlängd = Math.Round(sidlängd, 0);


                //Ser till att vi får rätt antal rader
                for (int i = 0; i < sidlängd; i++)
                {

                    //Ritar ut en rad
                    for (int j = 0; j < sidlängd; j++)
                    {
                        //Ett x för varje tal
                        Console.Write("x");
                    }
                    
                    //Färdig med en rad - ta ny rad!
                    Console.WriteLine();
                }
            }
        }



        //--------------------------------------------------------
    }
}
