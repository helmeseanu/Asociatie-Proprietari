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
    public partial class ShowUser_Form : Form
    {
        public ShowUser_Form()
        {
            InitializeComponent();
        }

        private void Button_AddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_ShowOk_Click(object sender, EventArgs e)
        {
            dataGridView_Show.Visible = true;

            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
            DataTable table = new DataTable();

            var results = from row in context.Membri_Asociatie
                          select new
                          { row.ID, row.Nume, row.Prenume, row.Numar_telefon, row.Emai, row.Functie, row.Data_Inscriere };

            table.Columns.Add("ID");
            table.Columns.Add("Nume");
            table.Columns.Add("Prenume");
            table.Columns.Add("Numar_telefon");
            table.Columns.Add("Emai");
            table.Columns.Add("Functie");
            table.Columns.Add("Data_Inscriere");

            foreach (var item in results)
            {
                table.Rows.Add(new object[] { item.ID, item.Nume, item.Prenume, item.Numar_telefon, item.Emai, item.Functie, item.Data_Inscriere });
            }

            dataGridView_Show.DataSource = table;
        }
    }
}
