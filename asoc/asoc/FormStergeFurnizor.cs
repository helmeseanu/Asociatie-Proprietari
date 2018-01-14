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
    public partial class FormStergeFurnizor : Form
    {
        public FormStergeFurnizor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.All(Char.IsDigit) != true || textBox1.Text.Length == 0)
            {
                MessageBox.Show("CUI invalid!", "Avertisment", MessageBoxButtons.OK);
            }
            else
            {
                using (var context = new Asociatie_ProprietariEntities())
                {
                    var furn = (from c in context.Furnizori
                                where c.CUI.ToString().Equals(textBox1.Text)
                                select c);

                    if (furn.ToList().Count!=0)
                    {
                        context.Furnizori.Remove(furn.ToList()[0]);
                        context.SaveChanges();
                        this.Close();
                    }
                    else MessageBox.Show("CUI inexistent!", "Avertisment", MessageBoxButtons.OK);
                }
            }
        }
    }
}
