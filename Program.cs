using System;


namespace HalloWeltBeispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nahrung = new string[4];

            nahrung[0] = "Wasserflasche";
            nahrung[1] = "Kaugummi";
            nahrung[2] = "Nudeln";
            nahrung[3] = "Kartoffeln";

            string[] nahrung2 = new string[]
            {
                "Wasserflasche",
                "Kaugummi",
                "Nudeln",
                "Kartoffeln",
            };

            string[,] name = new string[2, 4];
            name[0, 0] = "Sabine";
            name[1, 0] = "Müller";

            name[0, 1] = "Sandra";
            name[1, 1] = "Maier";

            name[0, 2] = "Klaus";
            name[1, 2] = "Schmied";

            name[0, 3] = "Max";
            name[1, 3] = "Mustermann";



            string[,] name2 = new string[,]
            {
                {
                    "Sabine",
                    "Sandra",
                    "Klaus",
                    "Max",
                },

                {
                    "Müller",
                    "Maier",
                    "Schmied",
                    "Mustermann",
                }

            };
          


        }


        

        private static string Ergeb(double zahl1, char oper, double zahl2)
        {
            string ergebnis = "";
            double berechnung = 0;


            switch (oper)
            {
                case '+':
                    berechnung = zahl1 + zahl2;
                    ergebnis = $"{zahl1} + {zahl2} = " + berechnung;
                    break;

                case '-':

                    berechnung = zahl1 - zahl2;
                    ergebnis = $"{zahl1} - {zahl2} = " + berechnung;
                    break;

                case '*':

                    berechnung = zahl1 * zahl2;
                    ergebnis = $"{zahl1} * {zahl2} = " + berechnung;
                    break;

                case '/':

                    berechnung = zahl1 / zahl2;
                    ergebnis = $"{zahl1} / {zahl2} = " + berechnung;
                    break;

            }

            return ergebnis;
        }



    }
}
