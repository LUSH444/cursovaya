using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursovaya
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_FormDataBase_Click(object sender, EventArgs e)
        {
            Form F1 = new FormDataBase();
            F1.Show();
            this.Visible = false;
        }

        private void btn_FormBMI_Click(object sender, EventArgs e)
        {
            Form F1 = new FormBMI();
            F1.Show();
            this.Visible = false;
        }

        private void btn_FormAbout_Click(object sender, EventArgs e)
        {
            Form F1 = new FormAbout();
            F1.Show();
            this.Visible = false;
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
