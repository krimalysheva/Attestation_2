namespace GridViewIdex
{
    partial class Ex6
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
            this.inputGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputSection = new System.Windows.Forms.GroupBox();
            this.OutputText = new System.Windows.Forms.Label();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).BeginInit();
            this.OutputSection.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGridView
            // 
            this.inputGridView.AllowUserToAddRows = false;
            this.inputGridView.AllowUserToDeleteRows = false;
            this.inputGridView.AllowUserToResizeColumns = false;
            this.inputGridView.AllowUserToResizeRows = false;
            this.inputGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.inputGridView.ColumnHeadersHeight = 30;
            this.inputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inputGridView.ColumnHeadersVisible = false;
            this.inputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.inputGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputGridView.Location = new System.Drawing.Point(12, 41);
            this.inputGridView.MultiSelect = false;
            this.inputGridView.Name = "inputGridView";
            this.inputGridView.RowHeadersVisible = false;
            this.inputGridView.RowHeadersWidth = 30;
            this.inputGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.inputGridView.RowTemplate.Height = 30;
            this.inputGridView.Size = new System.Drawing.Size(636, 271);
            this.inputGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // OutputSection
            // 
            this.OutputSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputSection.Controls.Add(this.OutputText);
            this.OutputSection.Location = new System.Drawing.Point(13, 357);
            this.OutputSection.Name = "OutputSection";
            this.OutputSection.Size = new System.Drawing.Size(636, 187);
            this.OutputSection.TabIndex = 3;
            this.OutputSection.TabStop = false;
            this.OutputSection.Text = "Результат вычислений:";
            // 
            // OutputText
            // 
            this.OutputText.AutoSize = true;
            this.OutputText.Location = new System.Drawing.Point(7, 20);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(0, 13);
            this.OutputText.TabIndex = 0;
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.FileName = "openFileDialog1";
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(12, 318);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(636, 33);
            this.ProcessBtn.TabIndex = 14;
            this.ProcessBtn.Text = "Выполнить";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFile});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(660, 24);
            this.MainMenu.TabIndex = 16;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainMenuFile
            // 
            this.MainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuFileSave,
            this.MainMenuFileSeparator1,
            this.MainMenuFileClose});
            this.MainMenuFile.Name = "MainMenuFile";
            this.MainMenuFile.Size = new System.Drawing.Size(48, 20);
            this.MainMenuFile.Text = "Файл";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileOpen.Text = "Открыть";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
            // 
            // MainMenuFileSave
            // 
            this.MainMenuFileSave.Name = "MainMenuFileSave";
            this.MainMenuFileSave.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileSave.Text = "Сохранить";
            this.MainMenuFileSave.Click += new System.EventHandler(this.MainMenuFileSave_Click);
            // 
            // MainMenuFileSeparator1
            // 
            this.MainMenuFileSeparator1.Name = "MainMenuFileSeparator1";
            this.MainMenuFileSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // MainMenuFileClose
            // 
            this.MainMenuFileClose.Name = "MainMenuFileClose";
            this.MainMenuFileClose.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileClose.Text = "Закрыть";
            this.MainMenuFileClose.Click += new System.EventHandler(this.MainMenuFileClose_Click);
            // 
            // Ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 556);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.OutputSection);
            this.Controls.Add(this.inputGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ex6";
            this.Text = "Задача 9.49";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).EndInit();
            this.OutputSection.ResumeLayout(false);
            this.OutputSection.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inputGridView;
        private System.Windows.Forms.GroupBox OutputSection;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.Label OutputText;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileSave;
        private System.Windows.Forms.ToolStripSeparator MainMenuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileClose;
    }
}

