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
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }

        private void FormBMI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form F1 = new FormMenu();
            F1.Show();
            this.Visible = false;
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            int I,J;
            string Height1 = tb_Height.Text;
            string Weight1 = tb_Weight.Text;
            int.TryParse(Height1, out I);
            int.TryParse(Weight1, out J);
            if ((I != 0 ) && (J != 0))
            {
                double Weight = Convert.ToDouble(tb_Weight.Text);
                double Height = Convert.ToDouble(tb_Height.Text) / 100;
                double Result = Math.Round(Convert.ToDouble(BMI(Height, Weight)), 1);

                if (rb_Male.Checked)
                {
                    pb_Picture.Image = Image.FromFile(@"img\Male.jpg");
                }
                if (rb_Female.Checked)
                {
                    pb_Picture.Image = Image.FromFile(@"img\Female.jpg");
                }
                lbl_Result.Text = "Ваш Индекс Массы Тела равен " + Result.ToString() + ".\n";
                if (Result < 18.5)
                {
                    lbl_Result.Text += "Дефицит массы тела.";
                    lbl_Result.ForeColor = Color.PeachPuff;
                }
                else if (Result >= 18.5 & Result < 25)
                {
                    lbl_Result.Text += "Нормальная масса тела.";
                    lbl_Result.ForeColor = Color.Green;
                }
                else if (Result >= 25 & Result < 30)
                {
                    lbl_Result.Text += "Увеличение массы тела.";
                    lbl_Result.ForeColor = Color.PeachPuff;
                }
                else if (Result >= 30 & Result < 35)
                {
                    lbl_Result.Text += "Ожирение 1-й степени.";
                    lbl_Result.ForeColor = Color.OrangeRed;
                }
                else if (Result >= 35 & Result < 40)
                {
                    lbl_Result.Text += "Ожирение 2-й степени.";
                    lbl_Result.ForeColor = Color.OrangeRed;
                }
                else if (Result >= 40)
                {
                    lbl_Result.Text += "Ожирение 3-й степени.";
                    lbl_Result.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные!");
                tb_Height.Text = "";
                tb_Weight.Text = "";
            }
        }

        public double BMI(double Height, double Weight)
        {
            return Weight / (Height * Height);
        }
    }
}
