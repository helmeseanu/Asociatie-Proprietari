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
    public partial class DeleteUser_Form : Form
    {
        private int _ID;

        public DeleteUser_Form()
        {
            InitializeComponent();
        }

        private void Button_AddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_AddOk_Click(object sender, EventArgs e)
        {
            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();

            try
            {
                _ID = Int32.Parse(textBox_ID.Text);

                var results = (from row in context.Membri_Asociatie
                               where row.ID.Equals(_ID)
                               select row).First();

                context.Membri_Asociatie.Remove(results);

                context.SaveChanges();

                textBox_ID.Clear();
            }
            catch
            {
                textBox_ID.Clear();

                MessageBox.Show("Incorrect ID");
            }
        }
    }
}
