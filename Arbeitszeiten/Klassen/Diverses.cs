using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arbeitszeiten.Klassen
{
    internal class Diverses
    {
        public static string Datum_Start_Ende(string ID,string Datum, string Beginn,string Ende)
        {
            string Datum_Start_Ende = string.Format("\n" +
                                                    "\tID:\t{0}\n" +
                                                    "\tDatum:\t{1}\n" +
                                                    "\tBeginn:\t{2}\n" +
                                                    "\tEnde:\t{3}", ID, Datum, Beginn, Ende);
            return Datum_Start_Ende;
        }
    }
}
