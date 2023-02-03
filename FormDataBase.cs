using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace cursovaya
{
    public partial class FormDataBase : Form
    {
        public static string connectionString = "Data Source=LUSH4\\SQLEXPRESS01;Initial Catalog=Cursovaya;Integrated Security=SSPI;" +
            "MultipleActiveResultSets=True";
        SqlConnection connection = new SqlConnection(connectionString);

        int ID;
        int ResponsibleStaffID;
        string NameOfWork;
        DateTime DateBegin;
        DateTime DateEnd;
        int CountOfWorkers;

        public FormDataBase()
        {
            connection.Open();

            InitializeComponent();

            // Заполнение элементов управления данными
            string SQL_Combobox1 = "SELECT [Surname] FROM [Staff]";
            string SQL_Combobox2 = "SELECT [NameOfWork] FROM [TypesOfWork]";

            SqlCommand command1 = new SqlCommand(SQL_Combobox1, connection);
            SqlCommand command2 = new SqlCommand(SQL_Combobox2, connection);

            SqlDataReader reader1 = command1.ExecuteReader();
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader1.Read())
            {
                cb_Surname.Items.Add(reader1["Surname"].ToString());
                cb_ResponsibleStaffID.Items.Add(reader1["Surname"].ToString());
            }
            cb_Surname.SelectedIndex = 0;

            while (reader2.Read())
            {
                cb_NameOfWork.Items.Add(reader2["NameOfWork"].ToString());
                cb_Name.Items.Add(reader2["NameOfWork"].ToString());
            }
            cb_NameOfWork.SelectedIndex = 0;

            string SQL_dgv1 = "SELECT * FROM [Works]";
            SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_dgv1, connection);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "components");
            dgv_Works.DataSource = ds1;
            dgv_Change.DataSource = ds1;
            dgv_Delete.DataSource = ds1;
            dgv_Works.DataMember = "components";
            dgv_Change.DataMember = "components";
            dgv_Delete.DataMember = "components";

            connection.Close();

            dt_DateBegin.Value = DateTime.Now;
            dt_DateEnd.Value = DateTime.Now;
        }

        private void FormDataBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form F1 = new FormMenu();
            F1.Show();
            this.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Присвоение выбранных значений переменным 
            ResponsibleStaffID = cb_Surname.SelectedIndex + 1;
            NameOfWork = cb_NameOfWork.SelectedItem.ToString();
            DateBegin = Convert.ToDateTime(dt_DateBegin.Value);
            DateEnd = Convert.ToDateTime(dt_DateEnd.Value);
            CountOfWorkers = Convert.ToInt32(num_CountOfWorkers.Value);

            connection.Open();

            // Запрос на выборку максимального ID и его инкрементирование  
            string SQL_Count = "SELECT TOP (1) [ID] FROM [Works] ORDER BY [ID] DESC";
            SqlCommand command1 = new SqlCommand(SQL_Count, connection);
            var QueryResult = command1.ExecuteScalar();
            if (QueryResult != null)
                ID = Convert.ToInt32(QueryResult) + 1;
            else
                ID = 1;
            
            // Запрос на добавление записи в БД
            string SQL_Add = "INSERT INTO Works VALUES (" + ID + ", " 
                                                        + ResponsibleStaffID + ", '" 
                                                        + NameOfWork + "', '" 
                                                        + DateBegin + "', '" 
                                                        + DateEnd + "', " 
                                                        + CountOfWorkers + ")";

            SqlCommand command2 = new SqlCommand(SQL_Add, connection);
            command2.ExecuteNonQuery();
            MessageBox.Show("Выполненная работа успешно добавлена!");

            string SQL_dgv2 = "SELECT * FROM [Works]";
            SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_dgv2, connection);
            DataSet ds2 = new DataSet();
            adapter1.Fill(ds2, "components");
            dgv_Works.DataSource = ds2;
            dgv_Works.DataMember = "components";

            connection.Close();
        }

        private void dgv_Change_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_ID.Text = Convert.ToString(Convert.ToInt32(dgv_Change.Rows[e.RowIndex].Cells[0].Value));

            // Заполнение элементов управление при выборе строки
            cb_ResponsibleStaffID.SelectedIndex = Convert.ToInt32(dgv_Change.Rows[e.RowIndex].Cells[1].Value) - 1;
            cb_Name.SelectedItem = dgv_Change.Rows[e.RowIndex].Cells[2].Value.ToString();
            dt_Begin.Value = Convert.ToDateTime(dgv_Change.Rows[e.RowIndex].Cells[3].Value);
            dt_End.Value = Convert.ToDateTime(dgv_Change.Rows[e.RowIndex].Cells[4].Value);
            if (Convert.ToInt32(dgv_Change.Rows[e.RowIndex].Cells[5].Value) < 1)
                num_Count.Value = 1;
            else
                num_Count.Value = Convert.ToInt32(dgv_Change.Rows[e.RowIndex].Cells[5].Value);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            connection.Open();

            // Запрос на изменение запииси в БД
            SqlCommand command = new SqlCommand("UPDATE [Works] SET ResponsibleStaffID = @ResponsibleStaffID, " +
                                                                    "NameOfWork = @NameOfWork," +
                                                                    "DateBegin = @DateBegin, " +
                                                                    "DateEnd = @DateEnd, " +
                                                                    "CountOfWorkers = @CountOfWorkers " +
                                                                    "WHERE ID = @ID", connection);

            int StaffID = cb_ResponsibleStaffID.SelectedIndex + 1;
            string Name = cb_Name.SelectedItem.ToString();
            DateTime Begin = Convert.ToDateTime(dt_Begin.Value);
            DateTime End = Convert.ToDateTime(dt_End.Value);
            int Count;

            if (Convert.ToInt32(num_Count.Value) < 1)
                Count = 1;
            else if (Convert.ToInt32(num_Count.Value) > 10)
                Count = 10;
            else
                Count = Convert.ToInt32(num_Count.Value);

            command.Parameters.AddWithValue("@ResponsibleStaffID", StaffID);
            command.Parameters.AddWithValue("@NameOfWork", Name);
            command.Parameters.AddWithValue("@DateBegin", Begin);
            command.Parameters.AddWithValue("@DateEnd", End);
            command.Parameters.AddWithValue("@CountOfWorkers", Count);
            command.Parameters.AddWithValue("@ID", Convert.ToInt32(lbl_ID.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена!");

            string SQL_dgv2 = "SELECT * FROM [Works]";
            SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_dgv2, connection);
            DataSet ds2 = new DataSet();
            adapter1.Fill(ds2, "components");
            dgv_Change.DataSource = ds2;
            dgv_Change.DataMember = "components";

            connection.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            connection.Open();

            // Запрос на удаление записи из БД
            SqlCommand command = new SqlCommand("DELETE FROM Works WHERE ID = @ID", connection);
            command.Parameters.AddWithValue("@ID", Convert.ToInt32(lbl_rowID.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно удалена!");

            string SQL_dgv2 = "SELECT * FROM [Works]";
            SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_dgv2, connection);
            DataSet ds2 = new DataSet();
            adapter1.Fill(ds2, "components");
            dgv_Delete.DataSource = ds2;
            dgv_Delete.DataMember = "components";

            connection.Close();
        }

        private void dgv_Delete_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_rowID.Text = Convert.ToString(Convert.ToInt32(dgv_Change.Rows[e.RowIndex].Cells[0].Value));
        }
    }
}
