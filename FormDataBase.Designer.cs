namespace cursovaya
{
    partial class FormDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Works = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.num_CountOfWorkers = new System.Windows.Forms.NumericUpDown();
            this.дид_CountOfWorkers = new System.Windows.Forms.Label();
            this.lbl_DateEnd = new System.Windows.Forms.Label();
            this.lbl_DateBegin = new System.Windows.Forms.Label();
            this.dt_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.dt_DateBegin = new System.Windows.Forms.DateTimePicker();
            this.lbl_NameOfWork = new System.Windows.Forms.Label();
            this.cb_NameOfWork = new System.Windows.Forms.ComboBox();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.cb_Surname = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.num_Count = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_End = new System.Windows.Forms.DateTimePicker();
            this.dt_Begin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ResponsibleStaffID = new System.Windows.Forms.ComboBox();
            this.dgv_Change = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_ResponsibleStaffID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Begin = new System.Windows.Forms.Label();
            this.lbl_End = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_Delete = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_rowID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Works)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountOfWorkers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Change)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 8);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 30);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akrobat Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Распределение дополнительных обязанностей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Akrobat Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 392);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_Works);
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Controls.Add(this.num_CountOfWorkers);
            this.tabPage1.Controls.Add(this.дид_CountOfWorkers);
            this.tabPage1.Controls.Add(this.lbl_DateEnd);
            this.tabPage1.Controls.Add(this.lbl_DateBegin);
            this.tabPage1.Controls.Add(this.dt_DateEnd);
            this.tabPage1.Controls.Add(this.dt_DateBegin);
            this.tabPage1.Controls.Add(this.lbl_NameOfWork);
            this.tabPage1.Controls.Add(this.cb_NameOfWork);
            this.tabPage1.Controls.Add(this.lbl_Surname);
            this.tabPage1.Controls.Add(this.cb_Surname);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Font = new System.Drawing.Font("Akrobat Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Works
            // 
            this.dgv_Works.AllowUserToAddRows = false;
            this.dgv_Works.AllowUserToDeleteRows = false;
            this.dgv_Works.AllowUserToResizeColumns = false;
            this.dgv_Works.AllowUserToResizeRows = false;
            this.dgv_Works.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Works.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Works.Location = new System.Drawing.Point(8, 109);
            this.dgv_Works.MultiSelect = false;
            this.dgv_Works.Name = "dgv_Works";
            this.dgv_Works.ReadOnly = true;
            this.dgv_Works.ShowCellErrors = false;
            this.dgv_Works.ShowCellToolTips = false;
            this.dgv_Works.ShowEditingIcon = false;
            this.dgv_Works.Size = new System.Drawing.Size(738, 241);
            this.dgv_Works.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(255, 67);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(225, 36);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // num_CountOfWorkers
            // 
            this.num_CountOfWorkers.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.num_CountOfWorkers.Location = new System.Drawing.Point(614, 31);
            this.num_CountOfWorkers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_CountOfWorkers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_CountOfWorkers.Name = "num_CountOfWorkers";
            this.num_CountOfWorkers.Size = new System.Drawing.Size(120, 30);
            this.num_CountOfWorkers.TabIndex = 9;
            this.num_CountOfWorkers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // дид_CountOfWorkers
            // 
            this.дид_CountOfWorkers.AutoSize = true;
            this.дид_CountOfWorkers.Location = new System.Drawing.Point(610, 5);
            this.дид_CountOfWorkers.Name = "дид_CountOfWorkers";
            this.дид_CountOfWorkers.Size = new System.Drawing.Size(126, 23);
            this.дид_CountOfWorkers.TabIndex = 8;
            this.дид_CountOfWorkers.Text = "Кол-во рабочих";
            // 
            // lbl_DateEnd
            // 
            this.lbl_DateEnd.AutoSize = true;
            this.lbl_DateEnd.Location = new System.Drawing.Point(486, 4);
            this.lbl_DateEnd.Name = "lbl_DateEnd";
            this.lbl_DateEnd.Size = new System.Drawing.Size(128, 23);
            this.lbl_DateEnd.TabIndex = 7;
            this.lbl_DateEnd.Text = "Дата окончания";
            // 
            // lbl_DateBegin
            // 
            this.lbl_DateBegin.AutoSize = true;
            this.lbl_DateBegin.Location = new System.Drawing.Point(377, 3);
            this.lbl_DateBegin.Name = "lbl_DateBegin";
            this.lbl_DateBegin.Size = new System.Drawing.Size(103, 23);
            this.lbl_DateBegin.TabIndex = 6;
            this.lbl_DateBegin.Text = "Дата начала";
            // 
            // dt_DateEnd
            // 
            this.dt_DateEnd.CustomFormat = "YYYY-MM-DD";
            this.dt_DateEnd.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.dt_DateEnd.Location = new System.Drawing.Point(490, 30);
            this.dt_DateEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dt_DateEnd.Name = "dt_DateEnd";
            this.dt_DateEnd.Size = new System.Drawing.Size(106, 30);
            this.dt_DateEnd.TabIndex = 5;
            this.dt_DateEnd.Value = new System.DateTime(2023, 2, 2, 0, 0, 0, 0);
            // 
            // dt_DateBegin
            // 
            this.dt_DateBegin.CustomFormat = "YYYY-MM-DD";
            this.dt_DateBegin.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.dt_DateBegin.Location = new System.Drawing.Point(381, 31);
            this.dt_DateBegin.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dt_DateBegin.Name = "dt_DateBegin";
            this.dt_DateBegin.Size = new System.Drawing.Size(103, 30);
            this.dt_DateBegin.TabIndex = 4;
            this.dt_DateBegin.Value = new System.DateTime(2023, 2, 2, 21, 23, 32, 0);
            // 
            // lbl_NameOfWork
            // 
            this.lbl_NameOfWork.AutoSize = true;
            this.lbl_NameOfWork.Location = new System.Drawing.Point(173, 4);
            this.lbl_NameOfWork.Name = "lbl_NameOfWork";
            this.lbl_NameOfWork.Size = new System.Drawing.Size(96, 23);
            this.lbl_NameOfWork.TabIndex = 3;
            this.lbl_NameOfWork.Text = "Вид работы";
            // 
            // cb_NameOfWork
            // 
            this.cb_NameOfWork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_NameOfWork.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_NameOfWork.FormattingEnabled = true;
            this.cb_NameOfWork.Location = new System.Drawing.Point(172, 30);
            this.cb_NameOfWork.Name = "cb_NameOfWork";
            this.cb_NameOfWork.Size = new System.Drawing.Size(203, 31);
            this.cb_NameOfWork.TabIndex = 2;
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(4, 4);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(172, 23);
            this.lbl_Surname.TabIndex = 1;
            this.lbl_Surname.Text = "Выберите сотрудника";
            // 
            // cb_Surname
            // 
            this.cb_Surname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_Surname.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_Surname.FormattingEnabled = true;
            this.cb_Surname.Location = new System.Drawing.Point(6, 30);
            this.cb_Surname.Name = "cb_Surname";
            this.cb_Surname.Size = new System.Drawing.Size(160, 31);
            this.cb_Surname.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.num_Count);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dt_End);
            this.tabPage2.Controls.Add(this.dt_Begin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cb_Name);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cb_ResponsibleStaffID);
            this.tabPage2.Controls.Add(this.dgv_Change);
            this.tabPage2.Controls.Add(this.btn_Refresh);
            this.tabPage2.Controls.Add(this.lbl_Title);
            this.tabPage2.Controls.Add(this.lbl_ID);
            this.tabPage2.Controls.Add(this.lbl_ResponsibleStaffID);
            this.tabPage2.Controls.Add(this.lbl_Name);
            this.tabPage2.Controls.Add(this.lbl_Begin);
            this.tabPage2.Controls.Add(this.lbl_End);
            this.tabPage2.Controls.Add(this.lbl_Count);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Font = new System.Drawing.Font("Akrobat Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // num_Count
            // 
            this.num_Count.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.num_Count.Location = new System.Drawing.Point(616, 278);
            this.num_Count.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Count.Name = "num_Count";
            this.num_Count.Size = new System.Drawing.Size(120, 30);
            this.num_Count.TabIndex = 28;
            this.num_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Кол-во рабочих";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата окончания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дата начала";
            // 
            // dt_End
            // 
            this.dt_End.CustomFormat = "YYYY-MM-DD";
            this.dt_End.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.dt_End.Location = new System.Drawing.Point(492, 277);
            this.dt_End.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dt_End.Name = "dt_End";
            this.dt_End.Size = new System.Drawing.Size(106, 30);
            this.dt_End.TabIndex = 24;
            this.dt_End.Value = new System.DateTime(2023, 2, 2, 0, 0, 0, 0);
            // 
            // dt_Begin
            // 
            this.dt_Begin.CustomFormat = "YYYY-MM-DD";
            this.dt_Begin.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.dt_Begin.Location = new System.Drawing.Point(383, 278);
            this.dt_Begin.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dt_Begin.Name = "dt_Begin";
            this.dt_Begin.Size = new System.Drawing.Size(103, 30);
            this.dt_Begin.TabIndex = 23;
            this.dt_Begin.Value = new System.DateTime(2023, 2, 2, 21, 23, 32, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Вид работы";
            // 
            // cb_Name
            // 
            this.cb_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_Name.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(174, 277);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(203, 31);
            this.cb_Name.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Выберите сотрудника";
            // 
            // cb_ResponsibleStaffID
            // 
            this.cb_ResponsibleStaffID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_ResponsibleStaffID.Font = new System.Drawing.Font("Akrobat Bold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_ResponsibleStaffID.FormattingEnabled = true;
            this.cb_ResponsibleStaffID.Location = new System.Drawing.Point(8, 277);
            this.cb_ResponsibleStaffID.Name = "cb_ResponsibleStaffID";
            this.cb_ResponsibleStaffID.Size = new System.Drawing.Size(160, 31);
            this.cb_ResponsibleStaffID.TabIndex = 19;
            // 
            // dgv_Change
            // 
            this.dgv_Change.AllowUserToAddRows = false;
            this.dgv_Change.AllowUserToDeleteRows = false;
            this.dgv_Change.AllowUserToResizeColumns = false;
            this.dgv_Change.AllowUserToResizeRows = false;
            this.dgv_Change.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Change.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Change.Location = new System.Drawing.Point(6, 56);
            this.dgv_Change.MultiSelect = false;
            this.dgv_Change.Name = "dgv_Change";
            this.dgv_Change.ReadOnly = true;
            this.dgv_Change.ShowCellErrors = false;
            this.dgv_Change.ShowCellToolTips = false;
            this.dgv_Change.ShowEditingIcon = false;
            this.dgv_Change.Size = new System.Drawing.Size(740, 193);
            this.dgv_Change.TabIndex = 12;
            this.dgv_Change.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Change_RowHeaderMouseClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(260, 314);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(225, 36);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Обновить";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(4, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(745, 49);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Установите маркер слева от нужной строки и укажите новые данные в соответствующих" +
    " полях, после чего нажмите кнопку \"Обновить\"";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(6, 30);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(53, 23);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "label2";
            this.lbl_ID.Visible = false;
            // 
            // lbl_ResponsibleStaffID
            // 
            this.lbl_ResponsibleStaffID.AutoSize = true;
            this.lbl_ResponsibleStaffID.Location = new System.Drawing.Point(66, 30);
            this.lbl_ResponsibleStaffID.Name = "lbl_ResponsibleStaffID";
            this.lbl_ResponsibleStaffID.Size = new System.Drawing.Size(53, 23);
            this.lbl_ResponsibleStaffID.TabIndex = 14;
            this.lbl_ResponsibleStaffID.Text = "label2";
            this.lbl_ResponsibleStaffID.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(126, 30);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 23);
            this.lbl_Name.TabIndex = 15;
            this.lbl_Name.Text = "label2";
            this.lbl_Name.Visible = false;
            // 
            // lbl_Begin
            // 
            this.lbl_Begin.AutoSize = true;
            this.lbl_Begin.Location = new System.Drawing.Point(186, 30);
            this.lbl_Begin.Name = "lbl_Begin";
            this.lbl_Begin.Size = new System.Drawing.Size(53, 23);
            this.lbl_Begin.TabIndex = 16;
            this.lbl_Begin.Text = "label2";
            this.lbl_Begin.Visible = false;
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.Location = new System.Drawing.Point(246, 30);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(53, 23);
            this.lbl_End.TabIndex = 17;
            this.lbl_End.Text = "label2";
            this.lbl_End.Visible = false;
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(306, 30);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(53, 23);
            this.lbl_Count.TabIndex = 18;
            this.lbl_Count.Text = "label2";
            this.lbl_Count.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_Delete);
            this.tabPage3.Controls.Add(this.btn_Delete);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lbl_rowID);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage3.Font = new System.Drawing.Font("Akrobat Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удаление";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_Delete
            // 
            this.dgv_Delete.AllowUserToAddRows = false;
            this.dgv_Delete.AllowUserToDeleteRows = false;
            this.dgv_Delete.AllowUserToResizeColumns = false;
            this.dgv_Delete.AllowUserToResizeRows = false;
            this.dgv_Delete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Delete.Location = new System.Drawing.Point(8, 29);
            this.dgv_Delete.MultiSelect = false;
            this.dgv_Delete.Name = "dgv_Delete";
            this.dgv_Delete.ReadOnly = true;
            this.dgv_Delete.ShowCellErrors = false;
            this.dgv_Delete.ShowCellToolTips = false;
            this.dgv_Delete.ShowEditingIcon = false;
            this.dgv_Delete.Size = new System.Drawing.Size(740, 280);
            this.dgv_Delete.TabIndex = 15;
            this.dgv_Delete.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Delete_RowHeaderMouseClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(260, 315);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(225, 36);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(745, 49);
            this.label7.TabIndex = 13;
            this.label7.Text = "Установите маркер слева от нужной строки и нажмите кнопку \"Удалить\"";
            // 
            // lbl_rowID
            // 
            this.lbl_rowID.AutoSize = true;
            this.lbl_rowID.Location = new System.Drawing.Point(17, 31);
            this.lbl_rowID.Name = "lbl_rowID";
            this.lbl_rowID.Size = new System.Drawing.Size(54, 23);
            this.lbl_rowID.TabIndex = 16;
            this.lbl_rowID.Text = "label8";
            this.lbl_rowID.Visible = false;
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Akrobat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Распределение дополнительных обязанностей сотрудников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDataBase_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Works)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountOfWorkers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Change)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label дид_CountOfWorkers;
        private System.Windows.Forms.Label lbl_DateEnd;
        private System.Windows.Forms.Label lbl_DateBegin;
        private System.Windows.Forms.DateTimePicker dt_DateEnd;
        private System.Windows.Forms.DateTimePicker dt_DateBegin;
        private System.Windows.Forms.Label lbl_NameOfWork;
        private System.Windows.Forms.ComboBox cb_NameOfWork;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.ComboBox cb_Surname;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.NumericUpDown num_CountOfWorkers;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView dgv_Works;
        private System.Windows.Forms.DataGridView dgv_Change;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ResponsibleStaffID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Begin;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.NumericUpDown num_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_End;
        private System.Windows.Forms.DateTimePicker dt_Begin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_ResponsibleStaffID;
        private System.Windows.Forms.DataGridView dgv_Delete;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_rowID;
    }
}