namespace tancverseny_applikacio
{
    partial class UserApplicationPoints
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
            dataGridView1 = new DataGridView();
            productionBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            applicantNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applyDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pointsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { applicantNameDataGridViewTextBoxColumn, productionNameDataGridViewTextBoxColumn, applyDateDataGridViewTextBoxColumn, competitionIdDataGridViewTextBoxColumn, pointsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productionBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(684, 188);
            dataGridView1.TabIndex = 0;
            // 
            // productionBindingSource
            // 
            productionBindingSource.DataSource = typeof(Data.Production);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 228);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 1;
            label1.Text = "Produkciók átlagos pontszáma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 228);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Még nincs pont";
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
            // productionNameDataGridViewTextBoxColumn
            // 
            productionNameDataGridViewTextBoxColumn.DataPropertyName = "ProductionName";
            productionNameDataGridViewTextBoxColumn.HeaderText = "Produkció címe";
            productionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productionNameDataGridViewTextBoxColumn.Name = "productionNameDataGridViewTextBoxColumn";
            productionNameDataGridViewTextBoxColumn.ReadOnly = true;
            productionNameDataGridViewTextBoxColumn.Width = 125;
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
            // pointsDataGridViewTextBoxColumn
            // 
            pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            pointsDataGridViewTextBoxColumn.HeaderText = "Pontszám";
            pointsDataGridViewTextBoxColumn.MinimumWidth = 6;
            pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            pointsDataGridViewTextBoxColumn.ReadOnly = true;
            pointsDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserApplicationPoints
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 327);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserApplicationPoints";
            Text = "UserApplicationPoints";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource productionBindingSource;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn applicantNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applyDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
    }
}