namespace _2
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
            label3 = new Label();
            label4 = new Label();
            sent = new TextBox();
            button1 = new Button();
            proc_sumbol = new Label();
            duble = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 76);
            label1.TabIndex = 0;
            label1.Text = "ЛАБОРАТОРНАЯ РАБОТА №2 \r\nЗАДАЧА№2 (Str)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 95);
            label2.Name = "label2";
            label2.Size = new Size(413, 73);
            label2.TabIndex = 1;
            label2.Text = "Дано предложение. Определить долю (в %) букв в нем.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(221, 28);
            label3.TabIndex = 2;
            label3.Text = "Введите предложение:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 332);
            label4.Name = "label4";
            label4.Size = new Size(294, 28);
            label4.TabIndex = 3;
            label4.Text = "Процент букв в предложении:";
            label4.Visible = false;
            // 
            // sent
            // 
            sent.Location = new Point(28, 208);
            sent.Name = "sent";
            sent.Size = new Size(423, 27);
            sent.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(105, 250);
            button1.Name = "button1";
            button1.Size = new Size(312, 33);
            button1.TabIndex = 6;
            button1.Text = "ВВОД";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // proc_sumbol
            // 
            proc_sumbol.AutoSize = true;
            proc_sumbol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            proc_sumbol.Location = new Point(312, 331);
            proc_sumbol.Name = "proc_sumbol";
            proc_sumbol.Size = new Size(125, 28);
            proc_sumbol.TabIndex = 7;
            proc_sumbol.Text = "proc_sumbol";
            proc_sumbol.Visible = false;
            // 
            // duble
            // 
            duble.AutoSize = true;
            duble.ForeColor = SystemColors.ControlDark;
            duble.Location = new Point(12, 302);
            duble.Name = "duble";
            duble.Size = new Size(47, 20);
            duble.TabIndex = 8;
            duble.Text = "duble";
            duble.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 382);
            Controls.Add(duble);
            Controls.Add(proc_sumbol);
            Controls.Add(button1);
            Controls.Add(sent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Задача Str";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox sent;
        private Button button1;
        private Label proc_sumbol;
        private Label duble;
    }
}