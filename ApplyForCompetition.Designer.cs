namespace tancverseny_applikacio
{
    partial class ApplyForCompetition
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
            competitionBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            competitionBindingSource1 = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applicationStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applicationEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // competitionBindingSource
            // 
            competitionBindingSource.DataSource = typeof(Data.Competition);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, placeDataGridViewTextBoxColumn, applicationStartDataGridViewTextBoxColumn, applicationEndDataGridViewTextBoxColumn, competitionStartDataGridViewTextBoxColumn, competitionEndDataGridViewTextBoxColumn });
            dataGridView1.DataSource = competitionBindingSource1;
            dataGridView1.Location = new Point(12, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1121, 188);
            dataGridView1.TabIndex = 0;
            // 
            // competitionBindingSource1
            // 
            competitionBindingSource1.DataSource = typeof(Data.Competition);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Verseny";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Dátum";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            placeDataGridViewTextBoxColumn.HeaderText = "Helyszín";
            placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            placeDataGridViewTextBoxColumn.ReadOnly = true;
            placeDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicationStartDataGridViewTextBoxColumn
            // 
            applicationStartDataGridViewTextBoxColumn.DataPropertyName = "ApplicationStart";
            applicationStartDataGridViewTextBoxColumn.HeaderText = "Jelentkezés kezdete";
            applicationStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            applicationStartDataGridViewTextBoxColumn.Name = "applicationStartDataGridViewTextBoxColumn";
            applicationStartDataGridViewTextBoxColumn.ReadOnly = true;
            applicationStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicationEndDataGridViewTextBoxColumn
            // 
            applicationEndDataGridViewTextBoxColumn.DataPropertyName = "ApplicationEnd";
            applicationEndDataGridViewTextBoxColumn.HeaderText = "Jelentkezés vége";
            applicationEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            applicationEndDataGridViewTextBoxColumn.Name = "applicationEndDataGridViewTextBoxColumn";
            applicationEndDataGridViewTextBoxColumn.ReadOnly = true;
            applicationEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // competitionStartDataGridViewTextBoxColumn
            // 
            competitionStartDataGridViewTextBoxColumn.DataPropertyName = "CompetitionStart";
            competitionStartDataGridViewTextBoxColumn.HeaderText = "Verseny kezdete";
            competitionStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            competitionStartDataGridViewTextBoxColumn.Name = "competitionStartDataGridViewTextBoxColumn";
            competitionStartDataGridViewTextBoxColumn.ReadOnly = true;
            competitionStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // competitionEndDataGridViewTextBoxColumn
            // 
            competitionEndDataGridViewTextBoxColumn.DataPropertyName = "CompetitionEnd";
            competitionEndDataGridViewTextBoxColumn.HeaderText = "Verseny vége";
            competitionEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            competitionEndDataGridViewTextBoxColumn.Name = "competitionEndDataGridViewTextBoxColumn";
            competitionEndDataGridViewTextBoxColumn.ReadOnly = true;
            competitionEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // ApplyForCompetition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 359);
            Controls.Add(dataGridView1);
            Name = "ApplyForCompetition";
            Text = "ApplyForCompetition";
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource competitionBindingSource;
        private DataGridView dataGridView1;
        private BindingSource competitionBindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applicationStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applicationEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionEndDataGridViewTextBoxColumn;
    }
}