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
    public partial class AddAngajati_Form : Form
    {
        private int _CUI;
        private string _prenume;
        private string _numar_telefon;
        private string _email;
        private string _functie;
        private string _data_inscriere;

        public AddAngajati_Form()
        {
            InitializeComponent();
        }

        private void Button_AddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_AddOk_Click(object sender, EventArgs e)
        {
            var context = new Asociatie_ProprietariEntities();

            var newCategory = new Membri_Asociatie()
            {
                //Nume = _nume,
                Prenume = _prenume,
                Numar_telefon = _numar_telefon,
                Emai = _email,
                Functie = _functie,
                Data_Inscriere = DateTime.Parse(_data_inscriere)
            };

            context.Membri_Asociatie.Add(newCategory);

            context.SaveChanges();
        }

        private void ListBox_SelectPropritate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = listBox_SelectPropritate.SelectedItem.ToString();

                int index = listBox_SelectPropritate.FindString(curItem);

                switch (curItem)
                {
                    case "Nume":
                        {
                            //_nume = textBox_Data.Text;

                            break;
                        }
                    case "Prenume":
                        {
                            _prenume = textBox_Data.Text;

                            break;
                        }
                    case "Numar Telefon":
                        {
                            _numar_telefon = textBox_Data.Text;

                            break;
                        }
                    case "Email":
                        {
                            _email = textBox_Data.Text;

                            break;
                        }
                    case "Functie":
                        {
                            _functie = textBox_Data.Text;

                            break;
                        }
                    case "Data Inscrierii":
                        {
                            _data_inscriere = textBox_Data.Text;

                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Error!");
                            break;
                        }
                }

                textBox_Data.Clear();
            }
            catch
            {
                MessageBox.Show("Select an Item");
            }
        }
    }
}
