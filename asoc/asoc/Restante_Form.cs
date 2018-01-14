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
    public partial class Restante_Form : Form
    {
        int id_membru;
        public Restante_Form(int numar_apartament, int Id_membru)
        {
            this.id_membru = Id_membru;

            InitializeComponent();

            var context = new Asociatie_ProprietariEntities();

            var t_restante = from c in context.Facturi_Clienti
                             join q in context.Restante on c.ID equals q.IDFactura
                             where c.IdApartament.Equals(numar_apartament)
                             select new
                             {
                                    c.ID,
                                    c.Total_de_Plata,
                                    q.Restante1,
                                    q.Penalizari_zi,
                                    c.Data_emitere,
                                    c.Data_Scadenta
                          
                             };
            
            if(t_restante.Count()==0)
            {
                restante_facturi_panel.Show();
            }
            else
            {
                restante_facturi_panel.Hide();
                dataGridView1.DataSource = t_restante.ToList();
                dataGridView1.Refresh();
                dataGridView1.Show();
                
            }
                             
        }

        private void Restante_Form_Load(object sender, EventArgs e)
        {

        }

        private void restante_buton_Click(object sender, EventArgs e)
        {
            var context = new Asociatie_ProprietariEntities();

            var carduri = from c in context.Carduri
                          where c.IdMembru.Equals(id_membru)
                          select c;

            if (carduri.Count() == 0)
            {
                MessageBox.Show("nu exista carduri introduse");
            }

        }
    }
}
