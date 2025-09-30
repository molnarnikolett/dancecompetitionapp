namespace tancverseny_applikacio
{
    partial class AcceptedApplications
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
            productionBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            productionBindingSource1 = new BindingSource(components);
            applicantNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            styleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musicNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musicianNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lengthOfMusicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applyDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // productionBindingSource
            // 
            productionBindingSource.DataSource = typeof(Data.Production);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { applicantNameDataGridViewTextBoxColumn, styleDataGridViewTextBoxColumn, productionNameDataGridViewTextBoxColumn, musicNameDataGridViewTextBoxColumn, musicianNameDataGridViewTextBoxColumn, lengthOfMusicDataGridViewTextBoxColumn, applyDateDataGridViewTextBoxColumn, competitionIdDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productionBindingSource1;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1311, 188);
            dataGridView1.TabIndex = 0;
            // 
            // productionBindingSource1
            // 
            productionBindingSource1.DataSource = typeof(Data.Production);
            // 
            // applicantNameDataGridViewTextBoxColumn
            // 
            applicantNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicantName";
            applicantNameDataGridViewTextBoxColumn.HeaderText = "Jelentkező neve";
            applicantNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            applicantNameDataGridViewTextBoxColumn.Name = "applicantNameDataGridViewTextBoxColumn";
            applicantNameDataGridViewTextBoxColumn.ReadOnly = true;
            applicantNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            styleDataGridViewTextBoxColumn.HeaderText = "Stílus";
            styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            styleDataGridViewTextBoxColumn.ReadOnly = true;
            styleDataGridViewTextBoxColumn.Width = 125;
            // 
            // productionNameDataGridViewTextBoxColumn
            // 
            productionNameDataGridViewTextBoxColumn.DataPropertyName = "ProductionName";
            productionNameDataGridViewTextBoxColumn.HeaderText = "Produkció címe";
            productionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productionNameDataGridViewTextBoxColumn.Name = "productionNameDataGridViewTextBoxColumn";
            productionNameDataGridViewTextBoxColumn.ReadOnly = true;
            productionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // musicNameDataGridViewTextBoxColumn
            // 
            musicNameDataGridViewTextBoxColumn.DataPropertyName = "MusicName";
            musicNameDataGridViewTextBoxColumn.HeaderText = "Zene";
            musicNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            musicNameDataGridViewTextBoxColumn.Name = "musicNameDataGridViewTextBoxColumn";
            musicNameDataGridViewTextBoxColumn.ReadOnly = true;
            musicNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // musicianNameDataGridViewTextBoxColumn
            // 
            musicianNameDataGridViewTextBoxColumn.DataPropertyName = "MusicianName";
            musicianNameDataGridViewTextBoxColumn.HeaderText = "Előadó";
            musicianNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            musicianNameDataGridViewTextBoxColumn.Name = "musicianNameDataGridViewTextBoxColumn";
            musicianNameDataGridViewTextBoxColumn.ReadOnly = true;
            musicianNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lengthOfMusicDataGridViewTextBoxColumn
            // 
            lengthOfMusicDataGridViewTextBoxColumn.DataPropertyName = "LengthOfMusic";
            lengthOfMusicDataGridViewTextBoxColumn.HeaderText = "Zenehossz";
            lengthOfMusicDataGridViewTextBoxColumn.MinimumWidth = 6;
            lengthOfMusicDataGridViewTextBoxColumn.Name = "lengthOfMusicDataGridViewTextBoxColumn";
            lengthOfMusicDataGridViewTextBoxColumn.ReadOnly = true;
            lengthOfMusicDataGridViewTextBoxColumn.Width = 125;
            // 
            // applyDateDataGridViewTextBoxColumn
            // 
            applyDateDataGridViewTextBoxColumn.DataPropertyName = "ApplyDate";
            applyDateDataGridViewTextBoxColumn.HeaderText = "Jelentkezési dátum";
            applyDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            applyDateDataGridViewTextBoxColumn.Name = "applyDateDataGridViewTextBoxColumn";
            applyDateDataGridViewTextBoxColumn.ReadOnly = true;
            applyDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // competitionIdDataGridViewTextBoxColumn
            // 
            competitionIdDataGridViewTextBoxColumn.DataPropertyName = "CompetitionId";
            competitionIdDataGridViewTextBoxColumn.HeaderText = "Verseny";
            competitionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            competitionIdDataGridViewTextBoxColumn.Name = "competitionIdDataGridViewTextBoxColumn";
            competitionIdDataGridViewTextBoxColumn.ReadOnly = true;
            competitionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "Állapot";
            stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Kezdési időpont";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // AcceptedApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 365);
            Controls.Add(dataGridView1);
            Name = "AcceptedApplications";
            Text = "AcceptedApplications";
            ((System.ComponentModel.ISupportInitialize)productionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource productionBindingSource;
        private DataGridView dataGridView1;
        private BindingSource productionBindingSource1;
        private DataGridViewTextBoxColumn applicantNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn musicNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn musicianNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lengthOfMusicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applyDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    }
}