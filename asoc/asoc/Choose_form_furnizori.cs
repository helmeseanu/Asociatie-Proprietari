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
    public partial class Choose_form_furnizori : Form
    {
        public Choose_form_furnizori()
        {
            InitializeComponent();
        }

        private void button_vizualizare_furnizori_Click(object sender, EventArgs e)
        {
            //Close();
            Form vezi_furnizori = new FormVizualizareFurnizori();
            vezi_furnizori.ShowDialog();
        }    

        private void button_sterge_furnizor_Click(object sender, EventArgs e)
        {
            //Close();
            Form sterg_furnizor = new FormStergeFurnizor();
            sterg_furnizor.ShowDialog();
        }

        private void button_adaugare_furnizor_Click(object sender, EventArgs e)
        {
            //Close();
            Form add_furnizori = new FormAdaugareFurnizor();
            add_furnizori.ShowDialog();
        }
    }
}
