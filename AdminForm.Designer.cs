namespace tancverseny_applikacio
{
    partial class AdminForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 70);
            button1.Name = "button1";
            button1.Size = new Size(205, 29);
            button1.TabIndex = 0;
            button1.Text = "Versenyek kezelése";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 120);
            button2.Name = "button2";
            button2.Size = new Size(229, 29);
            button2.TabIndex = 1;
            button2.Text = "Jelentkezések megtekintése";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 28);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 2;
            label1.Text = "Adminisztrátor Mód";
            // 
            // button3
            // 
            button3.Location = new Point(39, 168);
            button3.Name = "button3";
            button3.Size = new Size(158, 29);
            button3.TabIndex = 3;
            button3.Text = "Pontozás/nyertes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(39, 216);
            button4.Name = "button4";
            button4.Size = new Size(181, 29);
            button4.TabIndex = 4;
            button4.Text = "Jelentkezési statisztika";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(39, 264);
            button5.Name = "button5";
            button5.Size = new Size(152, 29);
            button5.TabIndex = 5;
            button5.Text = "Pont statisztika";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 325);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}