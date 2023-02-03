namespace cursovaya
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_FormDataBase = new System.Windows.Forms.Button();
            this.btn_FormBMI = new System.Windows.Forms.Button();
            this.btn_FormAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Akrobat Bold", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(134, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(476, 77);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "КУРСОВАЯ РАБОТА";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_FormDataBase
            // 
            this.btn_FormDataBase.Font = new System.Drawing.Font("Akrobat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FormDataBase.Location = new System.Drawing.Point(147, 120);
            this.btn_FormDataBase.Name = "btn_FormDataBase";
            this.btn_FormDataBase.Size = new System.Drawing.Size(463, 70);
            this.btn_FormDataBase.TabIndex = 1;
            this.btn_FormDataBase.Text = "Распределение доп. обязанностей";
            this.btn_FormDataBase.UseVisualStyleBackColor = true;
            this.btn_FormDataBase.Click += new System.EventHandler(this.btn_FormDataBase_Click);
            // 
            // btn_FormBMI
            // 
            this.btn_FormBMI.Font = new System.Drawing.Font("Akrobat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FormBMI.Location = new System.Drawing.Point(147, 220);
            this.btn_FormBMI.Name = "btn_FormBMI";
            this.btn_FormBMI.Size = new System.Drawing.Size(463, 70);
            this.btn_FormBMI.TabIndex = 2;
            this.btn_FormBMI.Text = "Калькулятор ИМТ";
            this.btn_FormBMI.UseVisualStyleBackColor = true;
            this.btn_FormBMI.Click += new System.EventHandler(this.btn_FormBMI_Click);
            // 
            // btn_FormAbout
            // 
            this.btn_FormAbout.Font = new System.Drawing.Font("Akrobat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FormAbout.Location = new System.Drawing.Point(147, 320);
            this.btn_FormAbout.Name = "btn_FormAbout";
            this.btn_FormAbout.Size = new System.Drawing.Size(463, 70);
            this.btn_FormAbout.TabIndex = 3;
            this.btn_FormAbout.Text = "Сведения о программе";
            this.btn_FormAbout.UseVisualStyleBackColor = true;
            this.btn_FormAbout.Click += new System.EventHandler(this.btn_FormAbout_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_FormAbout);
            this.Controls.Add(this.btn_FormBMI);
            this.Controls.Add(this.btn_FormDataBase);
            this.Controls.Add(this.lbl_Title);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_FormDataBase;
        private System.Windows.Forms.Button btn_FormBMI;
        private System.Windows.Forms.Button btn_FormAbout;
    }
}

