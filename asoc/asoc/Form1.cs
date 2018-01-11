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
    public partial class AsociatieProprietari : Form
    {
        public AsociatieProprietari()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void password_textbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void user_textbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (user_textbox.Text.Length!=0)
            {
                if(password_textbox.Text.Length!=0)
                {
                    using (var context = new Asociatie_ProprietariEntities())
                    {
                        var results = (from c in context.Conturi_de_Utilizator
                                       where c.Username == user_textbox.Text
                                       select new
                                       {
                                           c.Username,
                                           c.Parola
                                       });

                        if (results.ToArray()[0].Username==user_textbox.Text)
                        {
                            if(results.ToArray()[0].Parola == password_textbox.Text)
                            {
                                this.Close();
                            }
                            else MessageBox.Show("Parola gresita!", "Avertisment", MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("Utilizator inexistent!", "Avertisment", MessageBoxButtons.OK);
                    }
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Nu ai introdus parola!", "Avertisment", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nu ai introdus utilizatorul!", "Avertisment", MessageBoxButtons.OK);
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {

        }
    }
}
