namespace tehenAdatok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            trackBar1 = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(249, 32);
            label1.Name = "label1";
            label1.Size = new Size(211, 27);
            label1.TabIndex = 0;
            label1.Text = "Tejhozam lekérdezés";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 85);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 1;
            label2.Text = "Szarvasmarha azonosítója:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(89, 218);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 3;
            button1.Text = "Lekérdezés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 218);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 4;
            button2.Text = "Kilépés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 85);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Tej limit:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(325, 112);
            trackBar1.Maximum = 25;
            trackBar1.Minimum = 15;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(324, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 15;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 119);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "15 liter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 119);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "25 liter";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 164);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 10;
            label6.Text = "Beállított érték";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 266);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(trackBar1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Happy-Cow Nyírség Kft.";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private ComboBox comboBox1;
        private TrackBar trackBar1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
