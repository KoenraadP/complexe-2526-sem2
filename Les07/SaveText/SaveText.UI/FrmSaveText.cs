using SaveText.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // SaveText methode uit TextBll uitvoeren
            TextBll.SaveText(directory, title, text);
        }
    }
}
