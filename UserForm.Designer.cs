namespace tancverseny_applikacio
{
    partial class UserForm
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
            competitionBindingSource = new BindingSource(components);
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applicationStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applicationEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            competitionEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Winner = new DataGridViewTextBoxColumn();
            WinnerPoint = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, placeDataGridViewTextBoxColumn, applicationStartDataGridViewTextBoxColumn, applicationEndDataGridViewTextBoxColumn, competitionStartDataGridViewTextBoxColumn, competitionEndDataGridViewTextBoxColumn, Winner, WinnerPoint });
            dataGridView1.DataSource = competitionBindingSource;
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1185, 302);
            dataGridView1.TabIndex = 0;
            // 
            // competitionBindingSource
            // 
            competitionBindingSource.DataSource = typeof(Data.Competition);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Meghirdetett versenyek";
            // 
            // button1
            // 
            button1.Location = new Point(12, 420);
            button1.Name = "button1";
            button1.Size = new Size(229, 29);
            button1.TabIndex = 2;
            button1.Text = "Jelentkezések megtekintése";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 373);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 3;
            button2.Text = "Versenyjelentkezés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // Winner
            // 
            Winner.DataPropertyName = "Winner";
            Winner.HeaderText = "Nyertes";
            Winner.MinimumWidth = 6;
            Winner.Name = "Winner";
            Winner.ReadOnly = true;
            Winner.Width = 125;
            // 
            // WinnerPoint
            // 
            WinnerPoint.DataPropertyName = "WinnerPoint";
            WinnerPoint.HeaderText = "Nyertes pontja";
            WinnerPoint.MinimumWidth = 6;
            WinnerPoint.Name = "WinnerPoint";
            WinnerPoint.ReadOnly = true;
            WinnerPoint.Width = 125;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 523);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource competitionBindingSource;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applicationStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applicationEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn competitionEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Winner;
        private DataGridViewTextBoxColumn WinnerPoint;
    }
}