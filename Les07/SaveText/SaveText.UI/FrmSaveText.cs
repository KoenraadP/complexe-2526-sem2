using SaveText.Bll;
using System;
using System.IO;
using System.Windows.Forms;

namespace SaveText.UI
{
    public partial class FrmSaveText : Form
    {
        public FrmSaveText()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // tekst uit form in variabelen opslaan
            string title = txtTitle.Text;
            string text = txtStory.Text;
            string directory = @"C:\verhalen\";

            // SaveText in try/catch om fouten specifiek op te vangen
            try
            {
                // SaveText methode uit TextBll uitvoeren
                TextBll.SaveText(directory, title, text);
                MessageBox.Show(title + " is opgeslagen");
            }
            catch (DirectoryNotFoundException ex)
            {
                // foutmelding tonen en keuze yes/no opslaan in variabele
                DialogResult chosenOption = MessageBox.Show(ex.Message, "Map niet gevonden",
                    MessageBoxButtons.YesNo);
                
                // als ik op ja klik, map aanmaken
                if (chosenOption == DialogResult.Yes)
                {
                    Directory.CreateDirectory(directory);
                    // nog eens proberen bestand op te slaan
                    TextBll.SaveText(directory, title, text);
                    MessageBox.Show(title + " is opgeslagen");
                }
                else
                {
                    // programma afsluiten als er 'nee' gekozen werd
                    Close();
                }
            }
            // catch voor lege tekstvakken
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            // alle andere mogelijke fouten opvangen
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // 'dialoogvenster' tonen om bestand te kiezen
            ofd.ShowDialog();
        }

        // code die uitgevoerd wordt wanneer een bestand
        // correct geselecteerd werd om te openen
        private void Ofd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // volledige pad opslaan in variabele
            // voorbeeld: C:\verhalen\assepoester.txt
            string fullPath = ofd.FileName;

            // specifiek de naam van het bestand uit het pad halen
            string title = Path.GetFileNameWithoutExtension(fullPath);

            // tekst uit bestand tonen in correcte textboxes
            txtTitle.Text = title;
            txtStory.Text = File.ReadAllText(fullPath);
        }
    }
}
