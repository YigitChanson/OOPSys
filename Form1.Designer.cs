namespace UğraştırıcıFormUygulaması
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Circle", "Square", "Triangle" });
            comboBox1.Location = new Point(25, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(149, 31);
            label1.TabIndex = 1;
            label1.Text = "Select Shape";
            // 
            // button3
            // 
            button3.Location = new Point(12, 206);
            button3.Name = "button3";
            button3.Size = new Size(209, 180);
            button3.TabIndex = 4;
            button3.Text = "Press To Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(327, 46);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 5;
            label2.Text = "Circle";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(261, 95);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 7;
            label3.Text = "Radius";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(526, 95);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 10;
            label4.Text = "Edge Length";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(624, 46);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 8;
            label5.Text = "Square";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(638, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(256, 236);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 13;
            label6.Text = "Base Edge";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(454, 185);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 11;
            label7.Text = "Triangle";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(350, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(500, 236);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 15;
            label8.Text = "Second Edge";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(615, 236);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(252, 284);
            label9.Name = "label9";
            label9.Size = new Size(92, 23);
            label9.TabIndex = 17;
            label9.Text = "Third Edge";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(350, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(547, 285);
            label10.Name = "label10";
            label10.Size = new Size(62, 23);
            label10.TabIndex = 19;
            label10.Text = "Height";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(615, 284);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Shape Process";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button3;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
    }
}
