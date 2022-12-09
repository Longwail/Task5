namespace Task10Form
{
    partial class Form1
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
            this.res_TextBox = new System.Windows.Forms.TextBox();
            this.H_TextBox = new System.Windows.Forms.TextBox();
            this.start_TextBox = new System.Windows.Forms.TextBox();
            this.finish_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // res_TextBox
            // 
            this.res_TextBox.Location = new System.Drawing.Point(43, 173);
            this.res_TextBox.Multiline = true;
            this.res_TextBox.Name = "res_TextBox";
            this.res_TextBox.Size = new System.Drawing.Size(294, 108);
            this.res_TextBox.TabIndex = 0;
            // 
            // H_TextBox
            // 
            this.H_TextBox.Location = new System.Drawing.Point(85, 99);
            this.H_TextBox.Name = "H_TextBox";
            this.H_TextBox.Size = new System.Drawing.Size(100, 22);
            this.H_TextBox.TabIndex = 1;
            // 
            // start_TextBox
            // 
            this.start_TextBox.Location = new System.Drawing.Point(85, 31);
            this.start_TextBox.Name = "start_TextBox";
            this.start_TextBox.Size = new System.Drawing.Size(100, 22);
            this.start_TextBox.TabIndex = 2;
            // 
            // finish_TextBox
            // 
            this.finish_TextBox.Location = new System.Drawing.Point(85, 62);
            this.finish_TextBox.Name = "finish_TextBox";
            this.finish_TextBox.Size = new System.Drawing.Size(100, 22);
            this.finish_TextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Конец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шаг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finish_TextBox);
            this.Controls.Add(this.start_TextBox);
            this.Controls.Add(this.H_TextBox);
            this.Controls.Add(this.res_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox res_TextBox;
        private System.Windows.Forms.TextBox H_TextBox;
        private System.Windows.Forms.TextBox start_TextBox;
        private System.Windows.Forms.TextBox finish_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

