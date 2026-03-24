using SaveText.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
