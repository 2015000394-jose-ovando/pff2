﻿namespace WinFormsApp2
{
    partial class Form5
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 172);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 4;
            label3.Text = "el valor del resultado es: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 110);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "ingrese radio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "circulo";
            // 
            // button1
            // 
            button1.Location = new Point(171, 193);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 253);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}