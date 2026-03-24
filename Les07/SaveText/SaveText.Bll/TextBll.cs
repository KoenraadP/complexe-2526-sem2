using System.IO;

namespace SaveText.Bll
{
    public class TextBll
    {
        // methode die een string kan opslaan
        // in een tekstbestand op de computer
        // binnen een specifieke map
        // map = directory (of folder) in het Engels
        // voorbeeld directory: C:\verhalen\
        // voorbeeld title: doornroosje
        // voorbeeld text: het volledige verhaal
        public static void SaveText(string directory,
                            string title, string text)
        {
            // opbouwen pad om op te slaan, inclusief bestandsextensie
            // voorbeeld: C:\verhalen\sprookje.txt
            string fullPath = Path.Combine(directory, title + ".txt");

            // File is een ingebouwde class
            // uit de System.IO library
            // WriteAllText vereist een 'pad' --> voorbeeld c:\verhalen\doornroosje.txt
            // en contents --> de volledige tekst die in de file moet staan
            File.WriteAllText(fullPath, text);
        }
    }
}
