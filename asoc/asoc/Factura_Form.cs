using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asoc
{
    public partial class Factura_Form : Form
    {
        
        int numar_apartament;
        int id_membru;
        public Factura_Form(int numar_apartament, int Id_membru)
        {
            this.id_membru = Id_membru;
            this.numar_apartament = numar_apartament;
           

            InitializeComponent();
            var context = new Asociatie_ProprietariEntities();

            var t_facturi = from c in context.Facturi_Clienti
                            where c.IdApartament.Equals(numar_apartament) && c.Data_emitere.Month.Equals(DateTime.Today.Month)
                            select c;
            if (t_facturi.Count() == 0)
            {
                
                lipsa_facturi_panel.Show();
                dataGridView1.Hide();
                Servicii_contor_dataGridView.Hide();

            }
            else
            {
                data_emitere_label.Text += t_facturi.ToList()[0].Data_emitere.ToString();
                data_scadenta_label.Text += t_facturi.ToList()[0].Data_Scadenta.ToString();
                perioada_facturare_label.Text += t_facturi.ToList()[0].Perioada_Facturare.ToString();
                suma_label.Text += t_facturi.ToList()[0].Total_de_Plata.ToString();

    

                var result = from c in context.detaliiFactura1(DateTime.Today.Month.ToString(), numar_apartament, DateTime.Today.Year.ToString())
                             select c;
               Servicii_contor_dataGridView.DataSource = result.ToList();
               Servicii_contor_dataGridView.Refresh();
                var result1= from c in context.detaliiFactuaCotaParte1(DateTime.Today.Month.ToString(), numar_apartament, DateTime.Today.Year.ToString())
                             select c;
                dataGridView1.DataSource = result1.ToList();
                dataGridView1.Refresh();

                dataGridView1.Show();
                Servicii_contor_dataGridView.Show();
            }
        }

        private void Factura_Form_Load(object sender, EventArgs e)
        {

        }

        private void lipsa_facturi_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void factura_buton_Click(object sender, EventArgs e)
        {
            var context = new Asociatie_ProprietariEntities();

            var carduri = from c in context.Carduri
                          where c.IdMembru.Equals(id_membru)
                          select c;

            if(carduri.Count()==0)
            {
                MessageBox.Show("nu exista carduri introduse");
            }
           
        }
    }
}
