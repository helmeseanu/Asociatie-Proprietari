using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asoc
{
    public partial class ModifyUser_Form : Form
    {
        private string _nume;
        private string _prenume;
        private string _numar_telefon;
        private string _email;
        private string _functie;
        private string _data_inscriere;
        private int _ID;

        public ModifyUser_Form()
        {
            InitializeComponent();
        }

        private void Button_ModifyClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_ModifyOK_Click(object sender, EventArgs e)
        {
            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();

            try
            {
                _ID = Int32.Parse(textBox_ID.Text);
                _nume = textBox_Nume.Text;
                _prenume = textBox_Prenume.Text;
                _numar_telefon = textBox_NrTel.Text;
                _email = textBox_Email.Text;
                _functie = textBox_Functie.Text;
                _data_inscriere = textBox_DataInscriere.Text;


                var results = (from row in context.Membri_Asociatie
                               where row.ID.Equals(_ID)
                               select row).First();

                if (_nume != "")
                    results.Nume = _nume;

                if (_prenume != "")
                    results.Prenume = _prenume;

                if (_numar_telefon != "")
                    results.Numar_telefon = _numar_telefon;

                if (_email != "")
                    results.Emai = _email;

                if (_functie != "")
                    results.Functie = _functie;

                if (_data_inscriere != "")
                    results.Data_Inscriere = DateTime.Parse(_data_inscriere);

                context.SaveChanges();

                textBox_ID.Clear();
                textBox_Nume.Clear();
                textBox_Prenume.Clear();
                textBox_NrTel.Clear();
                textBox_Email.Clear();
                textBox_Functie.Clear();
                textBox_DataInscriere.Clear();
            }
            catch
            {
                textBox_ID.Clear();
                textBox_Nume.Clear();
                textBox_Prenume.Clear();
                textBox_NrTel.Clear();
                textBox_Email.Clear();
                textBox_Functie.Clear();
                textBox_DataInscriere.Clear();

                MessageBox.Show("Incorrect ID");
            }
        }
    }
}
