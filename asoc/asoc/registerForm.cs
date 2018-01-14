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
using System.Security.Cryptography;

namespace asoc
{
    public partial class registerForm : Form
    {
        private Membri_Asociatie datePersonale;
        private Conturi_de_Utilizator contUtilizator;
        private Apartamente[] ap_detinute = new Apartamente[20];
        private Locatari[] locatari = new Locatari[50];
        private int nr_ap_cur = 1, nr_ap_detinute = 1, locatar_cur=1;        

        public registerForm()
        {         
            InitializeComponent();           
            username_error_label.Hide();
            password_error_label.Hide();
            confirm_password_error_label.Hide();
            personalDataPanel.Hide();
            panel_inregistrare_apartamente.Hide();
            panel_inregistrare_locatari.Hide();
        }

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

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void registerForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Close();
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            int canCreateAccount = 1,canProcessNextStep=1;
            warning_label.Text="";

            //verific daca exista text in casete
            if (user_name_text_box.Text.Length == 0)
            {
                username_error_label.Show();
                canProcessNextStep = 0;
            }
            else username_error_label.Hide();
           
            if (password_text_box.Text.Length == 0)
            {
                password_error_label.Show();
                canProcessNextStep = 0;
            }
            else password_error_label.Hide();

            if (confirm_password_text_box.Text.Length == 0)
            {
                confirm_password_error_label.Show();
                canProcessNextStep = 0;
            }
            else confirm_password_error_label.Hide();

            //verific daca usernameul exista si parolele coincid
            if (canProcessNextStep == 1)
            {
                using (var context = new Asociatie_ProprietariEntities())
                {
                    var nume_utilizatori = (from c in context.Conturi_de_Utilizator
                                            where c.Username.TrimEnd().Equals(user_name_text_box.Text)
                                            select new
                                            {
                                                c.Username
                                            });

                    if (nume_utilizatori.Count() != 0)
                    {
                        if (nume_utilizatori.ToList()[0].Username.ToString().TrimEnd()==user_name_text_box.Text.TrimEnd())
                        {
                            warning_label.Text = "Userul exista!";
                            canCreateAccount = 0;
                        }                       
                    }

                    if (canCreateAccount == 1)
                    {
                        if (password_text_box.Text.Equals(confirm_password_text_box.Text) != true)
                        {
                            warning_label.Text = "Parolele nu coincid!";
                            canCreateAccount = 0;
                        }
                    }

                    if (canCreateAccount==1)
                    {
                        user_register_panel.Hide();
                        personalDataPanel.Show();
                        nume_error_label.Hide();
                        prenume_error_label.Hide();
                        numar_telefon_error_label.Hide();
                        email_error_label.Hide();

                        var contNou = new Conturi_de_Utilizator()                  //salvam datele personale ale utilizatorului
                        {
                            Username=user_name_text_box.Text,
                            Parola=sha256(password_text_box.Text),
                            Tip="User"
                        };
                        contUtilizator = contNou;
                    }
                }
            }
        }

        private void informatii_personale_next_Click(object sender, EventArgs e)
        {
            int canProcessNextStep = 1;
            warning_label.Text = "";

            //verific daca exista text in casete
            if (Nume_textBox.Text.Length == 0)
            {
                nume_error_label.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if(char.IsUpper(Nume_textBox.Text.ToString().First())!=true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Numele pot incepe doar cu litera mare!";
                }
                if(Nume_textBox.Text.All(Char.IsLetter)!=true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Numele pot contine doar litere!";
                }
                nume_error_label.Hide();
            }

            if (prenume_textBox.Text.Length == 0)
            {
                prenume_error_label.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if (char.IsUpper(prenume_textBox.Text.ToString().First()) != true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Prenumele pot incepe doar cu litera mare!";
                }
                if (prenume_textBox.Text.All(Char.IsLetter) != true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Prenumele pot contine doar litere!";
                }
                prenume_error_label.Hide();
            }

            if (numar_telefon_textBox.Text.Length == 0)
            {
                numar_telefon_error_label.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if(Regex.Match(numar_telefon_textBox.Text, @"^0[1-9][0-9]{8}$").Success!=true)
                {
                    warning_label.Text = "Format numar telefon invalid!";
                    canProcessNextStep = 0;
                }
                numar_telefon_error_label.Hide();
            }

            if (email_text_box.Text.Length == 0)
            {
                email_error_label.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if (Regex.Match(email_text_box.Text, @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"+ 
                                                     @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"+ 
                                                     @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$").Success != true)
                {
                    warning_label.Text = "Format e-mail invalid!";
                    canProcessNextStep = 0;
                }
                email_error_label.Hide();
            }

            if(canProcessNextStep==1)
            {
                var context = new Asociatie_ProprietariEntities();

                var membruAsociatieNou = new Membri_Asociatie()                  //salvam datele personale ale utilizatorului
                {
                    Nume = Nume_textBox.Text,
                    Prenume = prenume_textBox.Text,
                    Numar_telefon = numar_telefon_textBox.Text,
                    Emai = email_text_box.Text,
                    Functie = "Membru",
                    Data_Inscriere = DateTime.Today
                };

                datePersonale = membruAsociatieNou;
                personalDataPanel.Hide();
                panel_inregistrare_apartamente.Show();
                panel_date_apartament.Hide();                              
            }
        }

        private void informatii_personale_back_button_Click(object sender, EventArgs e)
        {
            personalDataPanel.Hide();
            user_register_panel.Show();
        }

        private void button_next_inregistrare_locatari_Click(object sender, EventArgs e)
        {
            nr_ap_cur++;
            if (nr_ap_cur < nr_ap_detinute+1)
            {
                //locatar_cur++;               
                textBox_nume_locatar.Text = "";
                textBox_prenume_locatar.Text = "";
                textBox_CNP.Text = "";
                textBox_data_mutare.Text = "";

                label_ap_cur_inreg_locatari.Text = ap_detinute[nr_ap_cur - 1].Numar.ToString();
            }

            if(nr_ap_cur==nr_ap_detinute)
            {
                button_next_inregistrare_locatari.Text = "Finalizare";
            }

            if (nr_ap_cur == nr_ap_detinute+1)
            {
                finishRegister();
            }
        }

        private void button_adaugare_locatar_Click(object sender, EventArgs e)
        {
            int canProcessNextStep = 1;
            warning_label.Text = "";

            //verific daca exista text in casete
            if (textBox_nume_locatar.Text.Length == 0)
            {
                label_eroare_nume_locatar.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if (char.IsUpper(textBox_nume_locatar.Text.ToString().First()) != true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Numele pot incepe doar cu litera mare!";
                }
                if (textBox_nume_locatar.Text.All(Char.IsLetter) != true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Numele pot contine doar litere!";
                }
                label_eroare_nume_locatar.Hide();
            }

            if (textBox_prenume_locatar.Text.Length == 0)
            {
                label_eroare_prenume_locatar.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if (char.IsUpper(textBox_prenume_locatar.Text.ToString().First()) != true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Prenumele pot incepe doar cu litera mare!";
                }
                if (textBox_prenume_locatar.Text.All(Char.IsLetter) != true)
                {
                    canProcessNextStep = 0;
                    warning_label.Text = "Prenumele pot contine doar litere!";
                }
                label_eroare_prenume_locatar.Hide();
            }

            if (textBox_CNP.Text.Length == 0)
            {
                label_eroare_CNP.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if (Regex.Match(textBox_CNP.Text, @"^(1|2)([1-9]{1}[0-9]{1})(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])([0-9]{6})$").Success != true)
                {
                    warning_label.Text = "Format CNP invalid!";
                    canProcessNextStep = 0;
                }
                label_eroare_CNP.Hide();
            }

            if (textBox_data_mutare.Text.Length == 0)
            {
                label_eroare_data_mutare.Show();
                canProcessNextStep = 0;
            }
            else
            {
                if (Regex.Match(textBox_data_mutare.Text, @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$").Success != true)
                {
                    warning_label.Text = "Format data invalid! (zz/ll/aaaa|zz.ll.aaaa|zz-ll-aaaa)";
                    canProcessNextStep = 0;
                }
                label_eroare_data_mutare.Hide();
            }

            if (canProcessNextStep == 1)
            {
                locatari[locatar_cur - 1] = new Locatari();
                locatari[locatar_cur - 1].Nume = textBox_nume_locatar.Text;
                locatari[locatar_cur - 1].Prenume = textBox_prenume_locatar.Text;
                locatari[locatar_cur - 1].CNP = textBox_CNP.Text;
                locatari[locatar_cur - 1].Data_Mutare =Convert.ToDateTime(textBox_data_mutare.Text);
                locatari[locatar_cur - 1].IdApartament = ap_detinute[nr_ap_cur - 1].Numar;

                locatar_cur++;

                textBox_nume_locatar.Text = "";
                textBox_prenume_locatar.Text = "";
                textBox_CNP.Text = "";
                textBox_data_mutare.Text = "";
            }
        }

        private void inregistrare_apartamente_next_Click(object sender, EventArgs e)
        {
            int canGoNext = 1,myInt=0,myInt2=0,myInt3=0,myInt1=0;
            if (panel_date_apartament.Visible==false)
            {
                nr_ap_detinute = (int)numarApartamenteSelect.Value;
                panel_date_apartament.Show();
                label_numar_apartamente.Hide();
                numarApartamenteSelect.Hide();
                label_eroare_numar_camere.Hide();
                label_eroare_suprafata.Hide();
                label_eroare_suprafata_utila.Hide();
                label_eroare_numar_apartament.Hide();
                label_numar_apartament_curent.Text = nr_ap_cur.ToString();
            }
            else if(nr_ap_cur!=nr_ap_detinute)
            {
                if (textBox_numar_apartament.Text.Length == 0 || int.TryParse(textBox_numar_apartament.Text, out myInt1) != true)
                {
                    label_eroare_numar_apartament.Show();
                    canGoNext = 0;
                }
                else label_eroare_numar_apartament.Hide();

                if (text_box_suprafata.Text.Length==0 || int.TryParse(text_box_suprafata.Text, out myInt)!=true)
                {
                    label_eroare_suprafata.Show();
                    canGoNext = 0;
                }
                else label_eroare_suprafata.Hide();

                if (text_box_suprafata_utila.Text.Length == 0 || int.TryParse(text_box_suprafata_utila.Text, out myInt2) != true || myInt2>myInt)
                {
                    label_eroare_suprafata_utila.Show();
                    canGoNext = 0;
                }
                else label_eroare_suprafata_utila.Hide();

                if (text_box_numar_camere.Text.Length == 0 || int.TryParse(text_box_numar_camere.Text, out myInt3) != true)
                {
                    label_eroare_numar_camere.Show();
                    canGoNext = 0;
                }
                else label_eroare_numar_camere.Hide();

                if (canGoNext != 0)
                {
                    ap_detinute[nr_ap_cur - 1] = new Apartamente();
                    ap_detinute[nr_ap_cur-1].Suprafata_mP_ = myInt;
                    ap_detinute[nr_ap_cur-1].Suprafata_utila_mP_ = myInt2;
                    ap_detinute[nr_ap_cur-1].Numar_Camere = myInt3;
                    ap_detinute[nr_ap_cur - 1].Numar = myInt1;
                    nr_ap_cur++;
                    label_numar_apartament_curent.Text = nr_ap_cur.ToString();
                    text_box_suprafata.Text = "";
                    text_box_suprafata_utila.Text = "";
                    text_box_numar_camere.Text = "";
                    textBox_numar_apartament.Text = "";
                }
            }
            else if (nr_ap_cur == nr_ap_detinute)
            {
                label_numar_apartament_curent.Text = nr_ap_cur.ToString();
                if (textBox_numar_apartament.Text.Length == 0 || int.TryParse(textBox_numar_apartament.Text, out myInt1) != true)
                {
                    label_eroare_numar_apartament.Show();
                    canGoNext = 0;
                }
                else label_eroare_numar_apartament.Hide();

                if (text_box_suprafata.Text.Length == 0 || int.TryParse(text_box_suprafata.Text, out myInt) != true)
                {
                    label_eroare_suprafata.Show();
                    canGoNext = 0;
                }
                else label_eroare_suprafata.Hide();

                if (text_box_suprafata_utila.Text.Length == 0 || int.TryParse(text_box_suprafata_utila.Text, out myInt2) != true || myInt2 > myInt)
                {
                    label_eroare_suprafata_utila.Show();
                    canGoNext = 0;
                }
                else label_eroare_suprafata_utila.Hide();

                if (text_box_numar_camere.Text.Length == 0 || int.TryParse(text_box_numar_camere.Text, out myInt3) != true)
                {
                    label_eroare_numar_camere.Show();
                    canGoNext = 0;
                }
                else label_eroare_numar_camere.Hide();

                if (canGoNext != 0)
                {
                    ap_detinute[nr_ap_cur - 1] = new Apartamente();
                    ap_detinute[nr_ap_cur-1].Suprafata_mP_ = myInt;
                    ap_detinute[nr_ap_cur-1].Suprafata_utila_mP_ = myInt2;
                    ap_detinute[nr_ap_cur-1].Numar_Camere = myInt3;
                    ap_detinute[nr_ap_cur - 1].Numar = myInt1;

                    panel_inregistrare_apartamente.Hide();
                    label_ap_cur_inreg_locatari.Text = ap_detinute.ToList()[0].Numar.ToString();
                    label_eroare_nume_locatar.Hide();
                    label_eroare_prenume_locatar.Hide();
                    label_eroare_CNP.Hide();
                    label_eroare_data_mutare.Hide();
                    panel_inregistrare_locatari.Show();

                    nr_ap_cur = 1;
                }
            }
        }

        private void finishRegister()
        {
            var context = new Asociatie_ProprietariEntities();
            
            context.Membri_Asociatie.Add(datePersonale);
            context.Conturi_de_Utilizator.Add(contUtilizator);

            for(int i=0;i<nr_ap_detinute;i++)
            {
                ap_detinute[i].Numar_locatari = calculeazaNumarulLocatarilor(ap_detinute[i].Numar);
                context.Apartamente.Add(ap_detinute[i]);
            }

            for(int i=0;i<locatar_cur-1;i++)
            {
                context.Locatari.Add(locatari[i]);
            }

            context.SaveChanges();

            this.Close();
        }

        private int calculeazaNumarulLocatarilor(int idApartament)
        {
            int nrLoc = 0;
            for(int i=0;i<locatar_cur-1;i++)
            {
                if (locatari.ToList()[i].IdApartament.ToString().Equals(idApartament.ToString())) nrLoc++;
            }
            return nrLoc;
        }
    }
}
