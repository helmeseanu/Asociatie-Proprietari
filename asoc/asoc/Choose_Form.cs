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
    public partial class Choose_Form : Form
    {
        public Choose_Form()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Close();

            AddUser_Form adduser_form = new AddUser_Form();
            adduser_form.ShowDialog();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Close();

            DeleteUser_Form deleteUser_Form = new DeleteUser_Form();
            deleteUser_Form.ShowDialog();
        }

        private void Button_Modify_Click(object sender, EventArgs e)
        {
            Close();

            ModifyUser_Form modifyuser_form = new ModifyUser_Form();
            modifyuser_form.ShowDialog();
        }

        private void Button_Show_Click(object sender, EventArgs e)
        {
            Close();

            ShowUser_Form showUser_Form = new ShowUser_Form();
            showUser_Form.ShowDialog();
        }
    }
}
