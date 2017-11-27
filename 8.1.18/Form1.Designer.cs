namespace Classist
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
            this.label1input = new System.Windows.Forms.Label();
            this.textBox1Progress = new System.Windows.Forms.TextBox();
            this.button8118 = new System.Windows.Forms.Button();
            this.labelOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1input
            // 
            this.label1input.AutoSize = true;
            this.label1input.Location = new System.Drawing.Point(39, 9);
            this.label1input.Name = "label1input";
            this.label1input.Size = new System.Drawing.Size(186, 13);
            this.label1input.TabIndex = 0;
            this.label1input.Text = "Введите вашу последовательность";
            // 
            // textBox1Progress
            // 
            this.textBox1Progress.Location = new System.Drawing.Point(42, 40);
            this.textBox1Progress.Name = "textBox1Progress";
            this.textBox1Progress.Size = new System.Drawing.Size(183, 20);
            this.textBox1Progress.TabIndex = 1;
            // 
            // button8118
            // 
            this.button8118.Location = new System.Drawing.Point(96, 82);
            this.button8118.Name = "button8118";
            this.button8118.Size = new System.Drawing.Size(75, 23);
            this.button8118.TabIndex = 2;
            this.button8118.UseVisualStyleBackColor = true;
            this.button8118.Click += new System.EventHandler(this.button8118_Click);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(42, 127);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(10, 13);
            this.labelOut.TabIndex = 3;
            this.labelOut.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 254);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.button8118);
            this.Controls.Add(this.textBox1Progress);
            this.Controls.Add(this.label1input);
            this.Name = "Form1";
            this.Text = "8.1.18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1input;
        private System.Windows.Forms.TextBox textBox1Progress;
        private System.Windows.Forms.Button button8118;
        private System.Windows.Forms.Label labelOut;
    }
}

