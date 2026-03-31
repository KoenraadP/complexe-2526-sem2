using Contacts.Bll;
using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Contacts.UI
{
    public partial class FrmContacts : Form
    {
        // globale variabelen (hoofdletter om onderscheid te zien)
        List<Person> LstPeople;

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
            LstPeople = ContactsBll.LoadContacts(ofd.FileName);

            // alle Person objecten in de combobox plaatsen
            foreach (Person p in LstPeople)
            {
                cbxContacts.Items.Add(p);
            }

            // eerste element uit combobox 'selecteren' (actief zetten)
            cbxContacts.SelectedIndex = 0;
        }

        private void CbxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // geselecteerde persoon uit combobox in variabele opslaan
            Person p = (Person)cbxContacts.SelectedItem;

            // alle tekstvelden invullen
            txtId.Text = p.Id.ToString();
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            txtEmail.Text = p.Email;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // updatedPerson aanmaken met data uit textboxes
            Person updatedPerson = new Person
            {
                Id = Convert.ToInt32(txtId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text
            };

            // methode uit bll uitvoeren om Person te updaten
            ContactsBll.UpdateContacts(updatedPerson, LstPeople);
            // combobox updaten
            UpdateBox();
            // juiste persoon opnieuw op 'selected' zetten in combobox
            cbxContacts.SelectedItem = updatedPerson;
            // nieuwe data ook opslaan in tekstbestand
            ContactsBll.UpdateFile(ofd.FileName, LstPeople);
        }

        // methode om combobox opnieuw 'op te bouwen' met data uit list
        private void UpdateBox()
        {
            cbxContacts.Items.Clear();
            foreach (Person p in LstPeople) 
                cbxContacts.Items.Add(p);
        }
    }
}
