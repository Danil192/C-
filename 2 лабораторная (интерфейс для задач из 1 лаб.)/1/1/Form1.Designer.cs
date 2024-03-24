namespace _1
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            mins = new Label();
            label7 = new Label();
            label8 = new Label();
            proizvedenie = new Label();
            l2 = new Label();
            l3 = new Label();
            l1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(141, 292);
            button1.Name = "button1";
            button1.Size = new Size(237, 38);
            button1.TabIndex = 0;
            button1.Text = "ВВОД ДАННЫХ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 20);
            label1.Name = "label1";
            label1.Size = new Size(405, 82);
            label1.TabIndex = 2;
            label1.Text = "ЛАБОРАТОРНАЯ РАБОТА №2  ЗАДАНИЕ №1 (IF)\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 190);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 3;
            label2.Text = "Число 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 259);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 5;
            label3.Text = "Число 3:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 226);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 7;
            label4.Text = "Число 2:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 27);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 346);
            label5.Name = "label5";
            label5.Size = new Size(245, 31);
            label5.TabIndex = 8;
            label5.Text = "Минимальные числа: ";
            label5.Visible = false;
            // 
            // mins
            // 
            mins.AutoSize = true;
            mins.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            mins.Location = new Point(247, 346);
            mins.Name = "mins";
            mins.Size = new Size(63, 31);
            mins.TabIndex = 9;
            mins.Text = "mins";
            mins.Visible = false;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(47, 111);
            label7.Name = "label7";
            label7.Size = new Size(419, 76);
            label7.TabIndex = 12;
            label7.Text = "Для нахождения произведения минимальных чисел введите 3 любых числа\r\n";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 388);
            label8.Name = "label8";
            label8.Size = new Size(398, 31);
            label8.TabIndex = 13;
            label8.Text = "Произведение минимальных чисел: ";
            label8.Visible = false;
            // 
            // proizvedenie
            // 
            proizvedenie.AutoSize = true;
            proizvedenie.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            proizvedenie.Location = new Point(407, 388);
            proizvedenie.Name = "proizvedenie";
            proizvedenie.Size = new Size(145, 31);
            proizvedenie.TabIndex = 14;
            proizvedenie.Text = "proizvedenie";
            proizvedenie.Visible = false;
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            l2.ForeColor = SystemColors.ControlDark;
            l2.Location = new Point(365, 229);
            l2.Name = "l2";
            l2.Size = new Size(21, 20);
            l2.TabIndex = 17;
            l2.Text = "l1";
            l2.Visible = false;
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            l3.ForeColor = SystemColors.ControlDark;
            l3.Location = new Point(365, 262);
            l3.Name = "l3";
            l3.Size = new Size(21, 20);
            l3.TabIndex = 16;
            l3.Text = "l3";
            l3.Visible = false;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            l1.ForeColor = SystemColors.ControlDark;
            l1.Location = new Point(365, 193);
            l1.Name = "l1";
            l1.Size = new Size(21, 20);
            l1.TabIndex = 15;
            l1.Text = "l2";
            l1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 446);
            Controls.Add(l2);
            Controls.Add(l3);
            Controls.Add(l1);
            Controls.Add(proizvedenie);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(mins);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Задача IF";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label mins;
        private Label label7;
        private Label label8;
        private Label proizvedenie;
        private Label l2;
        private Label l3;
        private Label l1;
    }
}