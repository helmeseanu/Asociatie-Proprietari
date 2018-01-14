using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace asoc
{
    public partial class FormAdaugareFurnizor : Form
    {
        public FormAdaugareFurnizor()
        {
            InitializeComponent();
            label_eroare.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int canAdd = 1;            

            if (textBox1.Text.All(Char.IsDigit) != true)
            {
                canAdd = 0;
                label_eroare.Text = "CUI-ul contine doar cifre!";
            }
            else label_eroare.Text = "";

            if (char.IsUpper(textBox2.Text.ToString().First()) != true)
            {
                canAdd = 0;
                label_eroare.Text = "Numele pot incepe doar cu litera mare!";
            }
            else label_eroare.Text = "";

            if (Regex.Match(textBox3.Text, @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" +
                                                     @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" +
                                                     @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$").Success != true)
            {
                label_eroare.Text = "Format e-mail invalid!";
                canAdd = 0;
            }
            else label_eroare.Text = "";

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                label_eroare.Text = "Completeaza toate casetele!";
                canAdd = 0;
            }
            else label_eroare.Text = "";

            if (canAdd == 1)
            {
                var context = new Asociatie_ProprietariEntities();
                var furnizor_nou = new Furnizori()
                {
                    CUI = System.Convert.ToDecimal(textBox1.Text),
                    Nume = textBox2.Text,
                    Email = textBox3.Text,
                    Serviciu = textBox4.Text,
                    Data_semnare_contract = DateTime.Today.AddYears(-1),
                    Data_expirare_contract = DateTime.Today.AddYears(+1)
                };

                context.Furnizori.Add(furnizor_nou);
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
