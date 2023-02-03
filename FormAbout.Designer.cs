namespace cursovaya
{
    partial class FormAbout
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.lbl_FIO = new System.Windows.Forms.Label();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Akrobat Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(170, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(420, 38);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Сведения об авторе приложения";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(12, 57);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(334, 392);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 3;
            this.pb_Image.TabStop = false;
            // 
            // lbl_FIO
            // 
            this.lbl_FIO.Font = new System.Drawing.Font("Akrobat Black", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FIO.Location = new System.Drawing.Point(353, 57);
            this.lbl_FIO.Name = "lbl_FIO";
            this.lbl_FIO.Size = new System.Drawing.Size(431, 238);
            this.lbl_FIO.TabIndex = 4;
            this.lbl_FIO.Text = "Савицких Вячеслав Александрович";
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Font = new System.Drawing.Font("Akrobat ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Group.Location = new System.Drawing.Point(359, 307);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(278, 38);
            this.lbl_Group.TabIndex = 5;
            this.lbl_Group.Text = "группа ТЗ-300901-ПИ";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_Group);
            this.Controls.Add(this.lbl_FIO);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.panel1);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Об авторе";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAbout_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label lbl_FIO;
        private System.Windows.Forms.Label lbl_Group;
    }
}