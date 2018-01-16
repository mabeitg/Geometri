using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arbeta i följande ordning:
            //1. Studera klassen RegelbundenFigur
            //
            //2. Färdigställ klassen Triangel. Kontrollera att den fungerar genom att skapa instanser och testa här i Main!
            //
            //3. Färdigställ klassen Kvadrat. Kontrollera att den fungerar genom att skapa instanser och testa här i Main!
            //
            //4. *Skapa en Cirkel-klass! 

            Triangel minTriangel = new Triangel(11);

            Console.WriteLine("Triangeln har arean: "+minTriangel.Area());
            Console.WriteLine("... och omkretsen: " +minTriangel.Omkrets());

            Kvadrat testkvadrat = new Kvadrat(6.4);

            Console.WriteLine("Kvadraten har så här långa sidor: "+testkvadrat.Sidlängd);

            testkvadrat.Sidlängd = 10;

            Console.WriteLine("Nu har kvadraten plötsligt så här långa sidor: " + testkvadrat.Sidlängd);

            testkvadrat.Draw();

            Console.ReadLine();
        }
    }
}
