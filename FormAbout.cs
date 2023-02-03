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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            pb_Image.Image = Image.FromFile(@"img\Male.jpg");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form F1 = new FormMenu();
            F1.Show();
            this.Visible = false;
        }

        private void FormAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
