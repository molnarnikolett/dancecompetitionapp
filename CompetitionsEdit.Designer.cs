namespace tancverseny_applikacio
{
    partial class CompetitionsEdit
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            competitionBindingSource = new BindingSource(components);
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applicationStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applicationEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Meghirdetett versenyek";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, nameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, placeDataGridViewTextBoxColumn, applicationStartDataGridViewTextBoxColumn, applicationEndDataGridViewTextBoxColumn, competitionStartDataGridViewTextBoxColumn, competitionEndDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.DataSource = competitionBindingSource;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1059, 188);
            dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(117, 24);
            deleteToolStripMenuItem.Text = "Törlés";
            // 
            // competitionBindingSource
            // 
            competitionBindingSource.DataSource = typeof(Data.Competition);
            // 
            // button1
            // 
            button1.Location = new Point(12, 271);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Azonosító";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Verseny";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Dátum";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            placeDataGridViewTextBoxColumn.HeaderText = "Helyszín";
            placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            placeDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicationStartDataGridViewTextBoxColumn
            // 
            applicationStartDataGridViewTextBoxColumn.DataPropertyName = "ApplicationStart";
            applicationStartDataGridViewTextBoxColumn.HeaderText = "Jelentkezés kezdete";
            applicationStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            applicationStartDataGridViewTextBoxColumn.Name = "applicationStartDataGridViewTextBoxColumn";
            applicationStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicationEndDataGridViewTextBoxColumn
            // 
            applicationEndDataGridViewTextBoxColumn.DataPropertyName = "ApplicationEnd";
            applicationEndDataGridViewTextBoxColumn.HeaderText = "Jelentkezés vége";
            applicationEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            applicationEndDataGridViewTextBoxColumn.Name = "applicationEndDataGridViewTextBoxColumn";
            applicationEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // competitionStartDataGridViewTextBoxColumn
            // 
            competitionStartDataGridViewTextBoxColumn.DataPropertyName = "CompetitionStart";
            competitionStartDataGridViewTextBoxColumn.HeaderText = "Verseny kezdete";
            competitionStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            competitionStartDataGridViewTextBoxColumn.Name = "competitionStartDataGridViewTextBoxColumn";
            competitionStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // competitionEndDataGridViewTextBoxColumn
            // 
            competitionEndDataGridViewTextBoxColumn.DataPropertyName = "CompetitionEnd";
            competitionEndDataGridViewTextBoxColumn.HeaderText = "Verseny vége";
            competitionEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            competitionEndDataGridViewTextBoxColumn.Name = "competitionEndDataGridViewTextBoxColumn";
            competitionEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // CompetitionsEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CompetitionsEdit";
            Text = "CompetitionsEdit";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource competitionBindingSource;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applicationStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applicationEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionEndDataGridViewTextBoxColumn;
    }
}