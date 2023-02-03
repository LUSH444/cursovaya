namespace cursovaya
{
    partial class FormBMI
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Height = new System.Windows.Forms.TextBox();
            this.tb_Weight = new System.Windows.Forms.TextBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.pb_Picture = new System.Windows.Forms.PictureBox();
            this.btn_Result = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 1;
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
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Akrobat Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(170, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(437, 38);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Калькулятор Индекса Массы Тела";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Akrobat Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите Ваш рост, вес и пол, и мы определим Ваш индекс массы тела, а также сможем" +
    " сделать вывод на его основе.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akrobat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите Ваш рост:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akrobat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(119, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите Ваш вес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Akrobat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(119, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Укажите Ваш пол:";
            // 
            // tb_Height
            // 
            this.tb_Height.Font = new System.Drawing.Font("Akrobat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Height.Location = new System.Drawing.Point(124, 144);
            this.tb_Height.Name = "tb_Height";
            this.tb_Height.Size = new System.Drawing.Size(169, 33);
            this.tb_Height.TabIndex = 6;
            this.tb_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Weight
            // 
            this.tb_Weight.Font = new System.Drawing.Font("Akrobat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Weight.Location = new System.Drawing.Point(123, 212);
            this.tb_Weight.Name = "tb_Weight";
            this.tb_Weight.Size = new System.Drawing.Size(169, 33);
            this.tb_Weight.TabIndex = 7;
            this.tb_Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Checked = true;
            this.rb_Male.Font = new System.Drawing.Font("Akrobat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Male.Location = new System.Drawing.Point(124, 280);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(107, 29);
            this.rb_Male.TabIndex = 8;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Мужчина";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Akrobat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Female.Location = new System.Drawing.Point(124, 305);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(111, 29);
            this.rb_Female.TabIndex = 9;
            this.rb_Female.Text = "Женщина";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // lbl_Result
            // 
            this.lbl_Result.Font = new System.Drawing.Font("Akrobat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Result.Location = new System.Drawing.Point(18, 385);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(754, 67);
            this.lbl_Result.TabIndex = 10;
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Picture
            // 
            this.pb_Picture.Location = new System.Drawing.Point(371, 112);
            this.pb_Picture.Name = "pb_Picture";
            this.pb_Picture.Size = new System.Drawing.Size(275, 271);
            this.pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Picture.TabIndex = 11;
            this.pb_Picture.TabStop = false;
            // 
            // btn_Result
            // 
            this.btn_Result.Font = new System.Drawing.Font("Akrobat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Result.Location = new System.Drawing.Point(124, 341);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(168, 42);
            this.btn_Result.TabIndex = 12;
            this.btn_Result.Text = "Рассчитать";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // FormBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.pb_Picture);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.rb_Female);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.tb_Weight);
            this.Controls.Add(this.tb_Height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBMI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBMI_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Height;
        private System.Windows.Forms.TextBox tb_Weight;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.PictureBox pb_Picture;
        private System.Windows.Forms.Button btn_Result;
    }
}