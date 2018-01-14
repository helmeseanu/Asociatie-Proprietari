using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace asoc
{
    public partial class AsociatieProprietari : Form
    {
        static string sha256(string randomString)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString), 0, Encoding.UTF8.GetByteCount(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public AsociatieProprietari()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_cod.Hide();
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
                                       where c.Username.Trim().Equals(user_textbox.Text)
                                       select new
                                       {
                                           c.Username,
                                           c.Parola,
                                           c.IdMembru,
                                           c.Tip
                                       });

                        if (results.Count() != 0 && results.ToList()[0].Username.TrimEnd() == user_textbox.Text)
                        {
                            if (results.ToList()[0].Parola.TrimEnd() == sha256(password_textbox.Text))
                            {
                                this.Hide();
                                /*if (results.ToList()[0].Tip.TrimEnd().Equals("User"))
                                {
                                    Form user_form = new User_Form(results.ToList()[0].IdMembru);
                                    user_form.ShowDialog();
                                }
                                else
                                {
                                    Form admin_form = new Admin_Form();
                                    admin_form.ShowDialog();
                                }*/                               
                            }
                            else MessageBox.Show("Parola gresita!", "Avertisment", MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("Utilizator inexistent!", "Avertisment", MessageBoxButtons.OK);
                    }                    
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
            user_label.Hide();
            password_label.Hide();
            panel_cod.Show();                     
        }

        void RegFormClosed(object sender, FormClosedEventArgs e)
        {
            user_label.Show();
            password_label.Show();
            panel_cod.Hide();
            this.Show();
        }

        private void button_cod_Click(object sender, EventArgs e)
        {
            using (var context = new Asociatie_ProprietariEntities())
            {
                var results = (from c in context.Coduri
                               where c.Cod.TrimEnd().Equals(textBox_cod.Text)
                               select c);

                if(results.Count()!=0)
                {
                    this.Hide();
                    foreach(var i in results) context.Coduri.Remove(i);
                    context.SaveChanges();
                    Form reg = new registerForm();
                    reg.FormClosed += new FormClosedEventHandler(RegFormClosed);
                    reg.ShowDialog();                  
                }
                else
                {
                    user_label.Show();
                    password_label.Show();
                    panel_cod.Hide();
                    MessageBox.Show("Cod invalid!", "Avertisment", MessageBoxButtons.OK);
                }
            }
        }
    }
}
