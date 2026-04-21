using System.IO;
using System;
using PdfSharp.Pdf;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using System.Diagnostics;

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
            // controleren of directory al bestaat op computer
            if (!Directory.Exists(directory))
            {
                throw new DirectoryNotFoundException("Map " +
                    directory + " bestaat niet. Wil je deze aanmaken?");
            }

            // controleren of titel en tekst niet leeg zijn
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Titel of tekst niet ingevuld");
            }

            // opbouwen pad om op te slaan, inclusief bestandsextensie
            // voorbeeld: C:\verhalen\sprookje.txt
            string fullPath = Path.Combine(directory, title + ".txt");

            // File is een ingebouwde class
            // uit de System.IO library
            // WriteAllText vereist een 'pad' --> voorbeeld c:\verhalen\doornroosje.txt
            // en contents --> de volledige tekst die in de file moet staan
            File.WriteAllText(fullPath, text);
        }

        // methode om de tekst als PDF op te slaan
        public static void SavePDF(string directory,
                            string title, string text)
        {
            // PDF document aanmaken in de code
            // (using PdfSharp.Pdf)
            PdfDocument pdfDocument = new PdfDocument();

            // lege pagina toevoegen aan document
            PdfPage page = pdfDocument.AddPage();

            // grootte pagina instellen
            // (using PdfSharp)
            page.Size = PageSize.A4;

            // XGraphics object aanmaken om de tekst 
            // te kunnen 'tekenen' op de pagina
            // (using PdfSharp.Drawing)
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // lettertype en lettergrootte instellen
            XFont font = new XFont("Verdana", 12);

            // een 'textformatter' aanmaken
            // zorgt er voor dat de tekst met enters kan werken
            // en niet zomaar in één lijn zal doorlopen
            // (using PdfSharp.Drawing.Layout;)
            XTextFormatter tf = new XTextFormatter(gfx);

            // tekst op de pagina 'tekenen'
            // XBrushes.Black --> zwarte tekst
            // XRect --> de 'rechthoek' waarin de tekst geplaatst wordt
            // eerste twee parameters bij XRect: marge links en boven
            // laatste twee parameters bij XRect: marge rechts en onderaan
            tf.DrawString(text, font,
                            XBrushes.Black,
                            new XRect(50, 50, page.Width.Point - 100,
                            page.Height.Point - 100));

            // pad samenstellen om op te slaan
            string fullPath = Path.Combine(directory, title + ".pdf");

            // pdf document effectief op de computer opslaan
            pdfDocument.Save(fullPath);

            // document al eens openen om te testen
            // Process komt uit System.Diagnostics
            Process.Start(fullPath);
        }
    }
}
