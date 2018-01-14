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
    public partial class Choose_Angajati : Form
    {
        public Choose_Angajati()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Close();

            AddAngajati_Form addfurnizor_form = new AddAngajati_Form();
            addfurnizor_form.ShowDialog();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Show_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
