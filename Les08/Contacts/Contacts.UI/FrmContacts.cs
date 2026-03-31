using Contacts.Bll;
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

namespace Contacts.UI
{
    public partial class FrmContacts : Form
    {
        public FrmContacts()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // pop-up 'dialog' voor open file tonen
            ofd.ShowDialog();
        }

        private void Ofd_FileOk(object sender, CancelEventArgs e)
        {
            // methode uit bll uitvoeren om tekstbestand in te lezen
            // fullpath --> ofd.FileName (voorbeeld c:\contacten\creo.txt)
            ContactsBll.LoadContacts(ofd.FileName);
        }
    }
}
