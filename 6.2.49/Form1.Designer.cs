namespace Test2
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputX = new System.Windows.Forms.TextBox();
            this.InputN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OutputBlock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputX
            // 
            this.InputX.Location = new System.Drawing.Point(80, 6);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(201, 20);
            this.InputX.TabIndex = 1;
            this.InputX.TextChanged += new System.EventHandler(this.InputX_TextChanged);
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(80, 33);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(201, 20);
            this.InputN.TabIndex = 3;
            this.InputN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число N:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InputE
            // 
            this.InputE.Location = new System.Drawing.Point(80, 59);
            this.InputE.Name = "InputE";
            this.InputE.Size = new System.Drawing.Size(201, 20);
            this.InputE.TabIndex = 5;
            this.InputE.TextChanged += new System.EventHandler(this.InputE_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Число E:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(15, 85);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(262, 72);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // OutputBlock
            // 
            this.OutputBlock.AutoSize = true;
            this.OutputBlock.Location = new System.Drawing.Point(22, 174);
            this.OutputBlock.Name = "OutputBlock";
            this.OutputBlock.Size = new System.Drawing.Size(0, 13);
            this.OutputBlock.TabIndex = 7;
            this.OutputBlock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.OutputBlock.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 219);
            this.Controls.Add(this.OutputBlock);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InputE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "6.2.49";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.TextBox InputN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label OutputBlock;
    }
}