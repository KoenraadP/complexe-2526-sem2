using Contacts.Bll;
using Contacts.Entities;
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
            // resultaat opslaan in variabele lstPeople
            List<Person> lstPeople = ContactsBll.LoadContacts(ofd.FileName);

            // alle Person objecten in de combobox plaatsen
            foreach (Person p in lstPeople)
            {
                cbxContacts.Items.Add(p);
            }
        }
    }
}
