using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asoc
{
    public partial class User_Form : Form
    {
        int Id_Membru_asociatie;
        int Numar_Apartament;
        List<string> Servicii_contracte_indv = new List<string> { "Apa Calda", "Agent termic", "Energie Electrica", "Gaz" };

        public User_Form(int IdMembru)
        {
            Id_Membru_asociatie = IdMembru;
            InitializeComponent();


            comboBox_Servicii.DataSource = Servicii_contracte_indv;

        }

        private void User_Form_Load(object sender, EventArgs e)
        {

        }
        private void button_Factura_Curenta_Click(object sender, EventArgs e)
        {
            //----show----
            factura_curenta_panel.Show();

            label_principal.Text = "Facturi curente";
            setNrapartament();
            apartamente_panel.Show();

            // ----Hide---
            contracteIndv_panel.Hide();
            panel_cont.Hide();
            label_principal.Hide();
            AC_panel.Hide();
            mainAuto_citire_panel.Hide(); Info_cont_panel.Hide();
            restante_panel.Hide();
            card_panel.Hide();


        }

        private void button_Restanta_Click(object sender, EventArgs e)
        {
            contracteIndv_panel.Hide();
            panel_cont.Hide();
            AC_panel.Hide();
            mainAuto_citire_panel.Hide();
            Info_cont_panel.Hide();
            factura_curenta_panel.Hide();
            label_principal.Hide();
            card_panel.Hide();

            setNrapartament();
            apartamente_panel.Show();
            restante_panel.Show();
          

        }

        private void button_Autocitire_Click(object sender, EventArgs e)
        {
            AC_panel.Show();
            label_principal.Text = "Autocitire Contoare";
            label_principal.Show();
            apartamente_panel.Show();
            setNrapartament();
            card_panel.Hide();


            //  -----Hide---
            contracteIndv_panel.Hide();
            panel_cont.Hide();
            textBox_index.Hide();
            label_index.Hide();
            mainAuto_citire_panel.Hide();
            Info_cont_panel.Hide();
            factura_curenta_panel.Hide();
            restante_panel.Hide();



        }

        private void comboBox_Apartamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(ComBoxApartamente.Text, out Numar_Apartament);
        }

        private void label_ListaApartamente_Click(object sender, EventArgs e)
        {

        }

        private void button_contracte_ind_Click(object sender, EventArgs e)
        {
            label_principal.Text = "Audaga contract individual";
            label_principal.Show();
            setNrapartament();
            apartamente_panel.Show();
            label_principal.Show();
            contracteIndv_panel.Show();
            Info_cont_panel.Hide();
            card_panel.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Servicii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_trimite_Click(object sender, EventArgs e)
        {
            DateTime d;
            Int32.TryParse(ComBoxApartamente.Text, out Numar_Apartament);

            if (textBox_contracte_inv.Text.Equals(""))
            {
                label_error.Show();
            }
            else
            {
                if (!DateTime.TryParse(textBox_contracte_inv.Text, out d))
                {

                    textBox_contracte_inv.Clear();
                    label_error.Show();
                }
                else
                {
                    try
                    {
                        var context = new Asociatie_ProprietariEntities();


                        var t_contracte = from c in context.Contracte_Individuale
                                          where c.IdApartament.Equals(Numar_Apartament) && c.Serviciu.TrimEnd().Equals(comboBox_Servicii.Text)
                                          select c;


                        if (t_contracte.Count() == 0)
                        {
                            context.Contracte_Individuale.Add(new Contracte_Individuale { IdApartament = Numar_Apartament, Serviciu = comboBox_Servicii.Text, Data = DateTime.Parse(textBox_contracte_inv.Text) });
                            context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Contractul exista in baza de date");
                        }
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText("errors.txt", "Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace + "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                        string New = Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine;
                        File.AppendAllText("errors.txt", New);
                        MessageBox.Show("Nu s-a putut adauga contractul");
                    }
                }
                textBox_contracte_inv.Clear();
            }
        }

        private void button_Iesire_Click(object sender, EventArgs e)
        {


            contracteIndv_panel.Hide();
            panel_cont.Hide();
            apartamente_panel.Hide();
            label_principal.Hide();
            Info_cont_panel.Hide();
            card_panel.Hide();
        }

        private void button_cont_Click(object sender, EventArgs e)
        {

            label_principal.Hide();
            panel_cont.Show();
            AC_panel.Hide();
            mainAuto_citire_panel.Hide();
            contracteIndv_panel.Hide();
            apartamente_panel.Hide();
            Info_cont_panel.Hide();
            factura_curenta_panel.Hide();
            restante_panel.Hide();
            card_panel.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label_error.Hide();
        }

        private void citireContoare_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void apaRece_button_Click(object sender, EventArgs e)
        {

        }

        private bool verifyContracteIndividuale(int nrApartament, string serviciu)
        {
            try
            {
                var context = new Asociatie_ProprietariEntities();


                var t_contracte = from c in context.Contracte_Individuale
                                  where c.IdApartament.Equals(nrApartament) && c.Serviciu.TrimEnd().Equals(serviciu)
                                  select c;


                if (t_contracte.Count() == 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("errors.txt", "Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace + "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                string New = Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine;
                File.AppendAllText("errors.txt", New);
                MessageBox.Show("Eroare de contectare la server");
            }

            return false;
        }

        private void iesireAC_button_Click(object sender, EventArgs e)
        {

        }

        private void label_data_Click(object sender, EventArgs e)
        {

        }

        private void button_info_Click(object sender, EventArgs e)
        {
            contracteIndv_panel.Hide();
            apartamente_panel.Hide();
            card_panel.Hide();
            label_principal.Text = "Informatii Cont";
            Info_cont_panel.Show();
            label_principal.Show();


            var context = new Asociatie_ProprietariEntities();

            var t_membrei = from c in context.Membri_Asociatie
                            where c.ID.Equals(Id_Membru_asociatie)
                            select c;

            nume_tb.Text = t_membrei.ToList()[0].Nume.TrimEnd().ToString();
            prenume_tb.Text = t_membrei.ToList()[0].Prenume.TrimEnd().ToString();
            nrtel_tb.Text = t_membrei.ToList()[0].Numar_telefon.TrimEnd().ToString();
            email_tb.Text = t_membrei.ToList()[0].Emai.TrimEnd().ToString();
            statut_tb.Text = t_membrei.ToList()[0].Functie.TrimEnd().ToString();


            trimite_info_cont.Enabled = false;
            nume_tb.ReadOnly = true;
            prenume_tb.ReadOnly = true;
            nrtel_tb.ReadOnly = true;
            email_tb.ReadOnly = true;
            statut_tb.ReadOnly = true;
        }

        private void button_info_apartmente_Click(object sender, EventArgs e)
        {
            contracteIndv_panel.Hide();
            Info_cont_panel.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void apartamente_panel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ComBoxApartamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(ComBoxApartamente.Text, out Numar_Apartament);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AC_panel.Hide();
            apartamente_panel.Hide();
            label_principal.Hide();
            mainAuto_citire_panel.Hide();
            textBox_index.Hide();
            label_index.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_index.Text = "Index Apa Calda";
            label_index.Show();
            textBox_index.Show();
            mainAuto_citire_panel.Show();
            trimite_apaCalda.Show();
            trimite_apaRece.Hide();
            trimite_gaz.Hide();
            trimite_electricitate.Hide();
        }

        private void textBox_index_TextChanged(object sender, EventArgs e)
        {
            index_error_ac.Hide();
        }

        private void sendAC_button_Click(object sender, EventArgs e)
        {
            int index;
            decimal consum;

            var context = new Asociatie_ProprietariEntities();

            var t_apaCalda = (from c in context.ApaCalda
                              where c.IdApartament.Equals(Numar_Apartament)
                              orderby c.Data_emitere descending
                              select c).Take(1);

            if (!Int32.TryParse(textBox_index.Text, out index))
            {
                index_error_ac.Show();
                textBox_index.Clear();
            }
            else
            {
                if (t_apaCalda.Count() != 0)
                {
                    if (t_apaCalda.ToList()[0].Data_emitere.Month.Equals(DateTime.Today.Month) && t_apaCalda.ToList()[0].Data_emitere.Year.Equals(DateTime.Today.Year))
                    {
                        MessageBox.Show("Citire deja inregistrata pentru luna curenta");
                        textBox_index.Clear();
                    }
                    else
                    {
                        if (index < t_apaCalda.ToList()[0].Index_Nou)
                        {
                            MessageBox.Show("Indexul este gresit!");
                            textBox_index.Clear();
                        }
                        else
                        {
                            consum = index - t_apaCalda.ToList()[0].Index_Vechi;
                            var newEnry = new ApaCalda()
                            {

                                IdApartament = Numar_Apartament,
                                Consum = index - t_apaCalda.ToList()[0].Index_Nou,
                                Index_Vechi = t_apaCalda.ToList()[0].Index_Nou,
                                Index_Nou = index,
                                Suma_de_Plata = t_apaCalda.ToList()[0].Pret_m_cub * consum,
                                Pret_m_cub = t_apaCalda.ToList()[0].Pret_m_cub,
                                Data_emitere = DateTime.Today
                            };

                            context.ApaCalda.Add(newEnry);
                            context.SaveChanges();

                        }
                    }
                }
                else
                {

                    if (t_apaCalda.Count() == 0)
                    {
                        var newEntry = new ApaCalda()
                        {
                            Index = 1,
                            IdApartament = Numar_Apartament,
                            Index_Vechi = 0,
                            Index_Nou = index,
                            Consum = index,
                            Pret_m_cub = 5,
                            Suma_de_Plata = 5 * index,
                            Data_emitere = DateTime.Today
                        };

                        context.ApaCalda.Add(newEntry);
                        context.SaveChanges();
                    }

                }
            }
        }

        private void label_index_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label_index.Text = "Index Apa Rece";
            label_index.Show();
            textBox_index.Show();
            mainAuto_citire_panel.Show();
            trimite_apaCalda.Hide();
            trimite_apaRece.Show();
            trimite_gaz.Hide();
            trimite_electricitate.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_index.Text = "Index Gaz";
            label_index.Show();
            textBox_index.Show();
            trimite_apaCalda.Hide();
            trimite_apaRece.Hide();
            trimite_gaz.Show();
            mainAuto_citire_panel.Show();
            trimite_electricitate.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label_index.Text = "Index Energie Electrica";
            label_index.Show();
            textBox_index.Show();
            trimite_apaCalda.Hide();
            trimite_apaRece.Hide();
            trimite_gaz.Hide();
            trimite_electricitate.Show();
            mainAuto_citire_panel.Show();
        }

        private void trimite_apaRece_Click(object sender, EventArgs e)
        {
            int index;
            decimal consum;
            var context = new Asociatie_ProprietariEntities();

            var t_apaRece = (from c in context.ApaRece
                             where c.IdApartament.Equals(Numar_Apartament)
                             orderby c.Data_emitere descending
                             select c).Take(1);

            if (!Int32.TryParse(textBox_index.Text, out index))
            {
                index_error_ac.Show();
                textBox_index.Clear();
            }
            else
            {
                if (t_apaRece.Count() != 0)
                {
                    if (t_apaRece.ToList()[0].Data_emitere.Month.Equals(DateTime.Today.Month) && t_apaRece.ToList()[0].Data_emitere.Year.Equals(DateTime.Today.Year))
                    {
                        MessageBox.Show("Citire deja inregistrata pentru luna curenta");
                        textBox_index.Clear();
                    }
                    else
                    {
                        if (index < t_apaRece.ToList()[0].Index_Nou)
                        {
                            MessageBox.Show("Indexul este gresit!");
                            textBox_index.Clear();
                        }
                        else
                        {
                            consum = index - t_apaRece.ToList()[0].Index_Vechi;
                            var newEnry = new ApaRece()
                            {

                                IdApartament = Numar_Apartament,
                                Consum = index - t_apaRece.ToList()[0].Index_Nou,
                                Index_Vechi = t_apaRece.ToList()[0].Index_Nou,
                                Index_Nou = index,
                                Suma_de_plata = t_apaRece.ToList()[0].Pret_m_cub * consum,
                                Pret_m_cub = t_apaRece.ToList()[0].Pret_m_cub,
                                Data_emitere = DateTime.Today
                            };

                            context.ApaRece.Add(newEnry);
                            context.SaveChanges();

                        }
                    }
                }
                else
                {

                    if (t_apaRece.Count() == 0)
                    {
                        var newEntry = new ApaRece()
                        {
                            Index = 1,
                            IdApartament = Numar_Apartament,
                            Index_Vechi = 0,
                            Index_Nou = index,
                            Consum = index,
                            Pret_m_cub = 3,
                            Suma_de_plata = 3 * index,
                            Data_emitere = DateTime.Today
                        };

                        context.ApaRece.Add(newEntry);
                        context.SaveChanges();
                    }

                }
            }
        }
    

        private void trimite_electricitate_Click(object sender, EventArgs e)
        {
            int index;
            decimal consum;
            var context = new Asociatie_ProprietariEntities();

            var t_electricitate = (from c in context.EnergieElectrica
                                   where c.IdApartament.Equals(Numar_Apartament)
                                   orderby c.Data_emitere descending
                                   select c).Take(1);

            if (!Int32.TryParse(textBox_index.Text, out index))
            {
                index_error_ac.Show();
                textBox_index.Clear();
            }
            else
            {
                if (t_electricitate.Count() != 0)
                {
                    if (t_electricitate.ToList()[0].Data_emitere.Month.Equals(DateTime.Today.Month) && t_electricitate.ToList()[0].Data_emitere.Year.Equals(DateTime.Today.Year))
                    {
                        MessageBox.Show("Citire deja inregistrata pentru luna curenta");
                        textBox_index.Clear();
                    }
                    else
                    {
                        if (index < t_electricitate.ToList()[0].Index_Nou)
                        {
                            MessageBox.Show("Indexul este gresit!");
                            textBox_index.Clear();
                        }
                        else
                        {
                            consum = index - t_electricitate.ToList()[0].Index_Vechi;
                            var newEnry = new EnergieElectrica()
                            {

                                IdApartament = Numar_Apartament,
                                Consum = index - t_electricitate.ToList()[0].Index_Nou,
                                Index_Vechi = t_electricitate.ToList()[0].Index_Nou,
                                Index_Nou = index,
                                Suma_de_plata = t_electricitate.ToList()[0].Pret_Kw * consum,
                                Pret_Kw = t_electricitate.ToList()[0].Pret_Kw,
                                Data_emitere = DateTime.Today
                            };

                            context.EnergieElectrica.Add(newEnry);
                            context.SaveChanges();

                        }
                    }
                }
                else
                {

                    if (t_electricitate.Count() == 0)
                    {
                        var newEntry = new EnergieElectrica()
                        {
                            Index = 1,
                            IdApartament = Numar_Apartament,
                            Index_Vechi = 0,
                            Index_Nou = index,
                            Consum = index,
                            Pret_Kw = 7,
                            Suma_de_plata = 7 * index,
                            Data_emitere = DateTime.Today
                        };

                        context.EnergieElectrica.Add(newEntry);
                        context.SaveChanges();
                    }

                }
            }
        }

        private void trimite_gaz_Click(object sender, EventArgs e)
        {
            int index;
            decimal consum;
            var context = new Asociatie_ProprietariEntities();

            var t_gaz = (from c in context.Gaz
                         where c.IdApartament.Equals(Numar_Apartament)
                         orderby c.Data_Emitere descending
                         select c).Take(1);


            if (!Int32.TryParse(textBox_index.Text, out index))
            {
                index_error_ac.Show();
                textBox_index.Clear();
            }
            else
            {
                if (t_gaz.Count() != 0)
                {
                    if (t_gaz.ToList()[0].Data_Emitere.Month.Equals(DateTime.Today.Month) && t_gaz.ToList()[0].Data_Emitere.Year.Equals(DateTime.Today.Year))
                    {
                        MessageBox.Show("Citire deja inregistrata pentru luna curenta");
                        textBox_index.Clear();
                    }

                    else
                    {
                        if (index < t_gaz.ToList()[0].Index_Nou)
                        {
                            MessageBox.Show("Indexul este gresit!");
                            textBox_index.Clear();
                        }
                        else
                        {
                            consum = index - t_gaz.ToList()[0].Index_Vechi;
                            var newEnry = new Gaz()
                            {

                                IdApartament = Numar_Apartament,
                                Consum = index - t_gaz.ToList()[0].Index_Nou,
                                Index_Vechi = t_gaz.ToList()[0].Index_Nou,
                                Index_Nou = index,
                                Suma_de_plata = t_gaz.ToList()[0].Pret_m_cub * consum,
                                Pret_m_cub = t_gaz.ToList()[0].Pret_m_cub,
                                Data_Emitere = DateTime.Today
                            };

                            context.Gaz.Add(newEnry);
                            context.SaveChanges();

                        }

                    }
                }
                else
                {

                    if (t_gaz.Count() == 0)
                    {
                        var newEntry = new Gaz()
                        {
                            Index = 1,
                            IdApartament = Numar_Apartament,
                            Index_Vechi = 0,
                            Index_Nou = index,
                            Consum = index,
                            Pret_m_cub = 6,
                            Suma_de_plata = 6 * index,
                            Data_Emitere = DateTime.Today
                        };

                        context.Gaz.Add(newEntry);
                        context.SaveChanges();
                    }

                }
            }
        }
    
        private void Info_cont_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nume_bt_Click(object sender, EventArgs e)
        {

            nume_tb.ReadOnly = false;
            
        }

        private void prenume_bt_Click(object sender, EventArgs e)
        {
            prenume_tb.ReadOnly = false;

        }

        private void nrtel_bt_Click(object sender, EventArgs e)
        {
            nrtel_tb.ReadOnly = false;
           
        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {
            
            trimite_info_cont.Enabled = true;


        }

        private void button_LogOFF_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }
private void exit()
        {
            throw new NotImplementedException();
        }

        private void trimite_info_cont_Click(object sender, EventArgs e)
        {


            if (trimite_info_cont.Enabled == false)
            {
                MessageBox.Show("Nu ati facut modificari");
            }
            else
            {

                try
                {
                    var context = new Asociatie_ProprietariEntities();

                    var t_membrei = (from c in context.Membri_Asociatie
                                     where c.ID.Equals(Id_Membru_asociatie)
                                     select c).First();

                    t_membrei.Nume = nume_tb.Text;
                    t_membrei.Prenume = prenume_tb.Text;
                    t_membrei.Emai = prenume_tb.Text;
                    t_membrei.Numar_telefon = nrtel_bt.Text;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    File.AppendAllText("errors.txt", "Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace + "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                    string New = Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine;
                    File.AppendAllText("errors.txt", New);
                    MessageBox.Show("Eroare");
                }

                MessageBox.Show("Succes!");
            }
        }
        private void nume_tb_TextChanged(object sender, EventArgs e)
        {
            trimite_info_cont.Enabled = true;
        }

        private void prenume_tb_TextChanged(object sender, EventArgs e)
        {
            trimite_info_cont.Enabled = true;

        }

        private void nrtel_tb_TextChanged(object sender, EventArgs e)
        {
            trimite_info_cont.Enabled = true;

        }

        private void email_bt_Click(object sender, EventArgs e)
        {
            email_tb.ReadOnly = false;
        }

        private void factura_buton_Click(object sender, EventArgs e)
        {
            Form factura_form = new Factura_Form(Int32.Parse(ComBoxApartamente.Text), Id_Membru_asociatie );
            factura_form.Show();
        }




        //////////////my funtions
        private bool verifyContracteInd(int nrApartamente, string serviciu)
        {

            var context = new Asociatie_ProprietariEntities();


            var t_contracte = from c in context.Contracte_Individuale
                              where c.IdApartament.Equals(nrApartamente) && c.Serviciu.TrimEnd().Equals(serviciu)
                              select new
                              {
                                  c
                              };

            if (t_contracte.Count() == 0)
            {
                return true;
            }

            return false;
        }
        private void setNrapartament()
        {
            var context = new Asociatie_ProprietariEntities();


            var t_apartamene = from c in context.Apartamente
                               where c.IdProprietar.Equals(Id_Membru_asociatie)
                               select new
                               {
                                   c.Numar
                               };

            ComBoxApartamente.DataSource = t_apartamene.ToList();
            ComBoxApartamente.DisplayMember = "Numar";

        }

        private void restante_button_Click(object sender, EventArgs e)
        {
             Form restante_form = new Restante_Form(Int32.Parse(ComBoxApartamente.Text), Id_Membru_asociatie);
             restante_form.Show();
        }

        private void card_button_Click(object sender, EventArgs e)
        {
            label_principal.Text = "Audaga card";
            label_principal.Show();
            apartamente_panel.Hide();
            label_principal.Show();
            contracteIndv_panel.Hide();
            Info_cont_panel.Hide();

            card_panel.Show();
           
        }

        private void adauga_card_button_Click(object sender, EventArgs e)
        {
            int _cvc;

            var context = new Asociatie_ProprietariEntities();

            var carduri = from c in context.Carduri
                          where c.Numar_Card.TrimEnd().Equals(nr_cont_textBox.Text) && c.IdMembru.Equals(Id_Membru_asociatie)
                          select c;
            if (carduri.Count() != 0)
            {
                MessageBox.Show("Cardul deja exista");
            }
            else
            {
                if (nr_cont_textBox.Text.Length != 16)
                {
                    nr_cont_textBox.Clear();
                    cvc_textBox.Clear();
                    dateexp_textBox.Clear();
                    MessageBox.Show("nr cont gresit");
                }
                else
                {
                    if (Int32.TryParse(cvc_textBox.Text, out _cvc) && _cvc.ToString().Length != 3)
                    {
                        nr_cont_textBox.Clear();
                        cvc_textBox.Clear();
                        dateexp_textBox.Clear();
                        MessageBox.Show("cvc gresit");
                    }
                    else
                    {
                        
                        var t_carduri = new Carduri();
                        {
                            t_carduri.CVC = Int32.Parse(cvc_textBox.Text);
                            t_carduri.Numar_Card = nr_cont_textBox.Text;
                            t_carduri.Data_Expirare = DateTime.Parse(dateexp_textBox.Text);
                            t_carduri.IdMembru = Id_Membru_asociatie;
                        };


                        context.Carduri.Add(t_carduri);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void nr_cont_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        //

    }
}
