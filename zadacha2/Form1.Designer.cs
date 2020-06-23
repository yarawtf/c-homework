namespace zadacha2
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
            this.Riddle = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblCounts = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Riddle
            // 
            this.Riddle.AutoSize = true;
            this.Riddle.Location = new System.Drawing.Point(220, 96);
            this.Riddle.Name = "Riddle";
            this.Riddle.Size = new System.Drawing.Size(296, 13);
            this.Riddle.TabIndex = 0;
            this.Riddle.Text = "Я загадал число от 1 до 100. Угадывай, кожаный мешок";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(306, 185);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Location = new System.Drawing.Point(303, 265);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(110, 13);
            this.lblCounts.TabIndex = 2;
            this.lblCounts.Text = "Количество ходов: 0";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(320, 337);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Riddle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Riddle;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.Button OK;
    }
}

