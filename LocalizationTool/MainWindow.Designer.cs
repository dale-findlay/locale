namespace LocalizationTool
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageBindingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stringIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishTranslationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frenchTranslationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingBindingSource)).BeginInit();
            this.dataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1636, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // languageBindingBindingSource
            // 
            this.languageBindingBindingSource.DataSource = typeof(LocalizationTool.LanguageBinding);
            // 
            // dataGridViewPanel
            // 
            this.dataGridViewPanel.AutoSize = true;
            this.dataGridViewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataGridViewPanel.Controls.Add(this.dataGridView1);
            this.dataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPanel.Location = new System.Drawing.Point(299, 24);
            this.dataGridViewPanel.MinimumSize = new System.Drawing.Size(1064, 794);
            this.dataGridViewPanel.Name = "dataGridViewPanel";
            this.dataGridViewPanel.Size = new System.Drawing.Size(1337, 794);
            this.dataGridViewPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stringIDDataGridViewTextBoxColumn,
            this.englishTranslationDataGridViewTextBoxColumn,
            this.frenchTranslationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.languageBindingBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1337, 794);
            this.dataGridView1.TabIndex = 0;
            // 
            // stringIDDataGridViewTextBoxColumn
            // 
            this.stringIDDataGridViewTextBoxColumn.DataPropertyName = "stringID";
            this.stringIDDataGridViewTextBoxColumn.HeaderText = "String ID";
            this.stringIDDataGridViewTextBoxColumn.Name = "stringIDDataGridViewTextBoxColumn";
            this.stringIDDataGridViewTextBoxColumn.ToolTipText = "The string ID.";
            // 
            // englishTranslationDataGridViewTextBoxColumn
            // 
            this.englishTranslationDataGridViewTextBoxColumn.DataPropertyName = "englishTranslation";
            this.englishTranslationDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishTranslationDataGridViewTextBoxColumn.Name = "englishTranslationDataGridViewTextBoxColumn";
            this.englishTranslationDataGridViewTextBoxColumn.ToolTipText = "The English Translation";
            // 
            // frenchTranslationDataGridViewTextBoxColumn
            // 
            this.frenchTranslationDataGridViewTextBoxColumn.DataPropertyName = "frenchTranslation";
            this.frenchTranslationDataGridViewTextBoxColumn.HeaderText = "<LANGUAGE>";
            this.frenchTranslationDataGridViewTextBoxColumn.Name = "frenchTranslationDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MinimumSize = new System.Drawing.Size(295, 794);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 794);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Properties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 818);
            this.Controls.Add(this.dataGridViewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Localization Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingBindingSource)).EndInit();
            this.dataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.BindingSource languageBindingBindingSource;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.Panel dataGridViewPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stringIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishTranslationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frenchTranslationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

