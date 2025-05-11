namespace WinFormsApp2
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
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            convercionesToolStripMenuItem = new ToolStripMenuItem();
            centimetroAMetrosToolStripMenuItem = new ToolStripMenuItem();
            metrosAKilometrosToolStripMenuItem = new ToolStripMenuItem();
            milimetrosAMetrosToolStripMenuItem = new ToolStripMenuItem();
            pulgadasACentimetrosToolStripMenuItem = new ToolStripMenuItem();
            piesAMetrosToolStripMenuItem = new ToolStripMenuItem();
            yardasAMetrosToolStripMenuItem = new ToolStripMenuItem();
            acresAMetrosToolStripMenuItem = new ToolStripMenuItem();
            hectareaAMetrosToolStripMenuItem = new ToolStripMenuItem();
            creditosToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.visa_4;
            pictureBox1.Location = new Point(182, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { convercionesToolStripMenuItem, creditosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(519, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // convercionesToolStripMenuItem
            // 
            convercionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centimetroAMetrosToolStripMenuItem, metrosAKilometrosToolStripMenuItem, milimetrosAMetrosToolStripMenuItem, pulgadasACentimetrosToolStripMenuItem, piesAMetrosToolStripMenuItem, yardasAMetrosToolStripMenuItem, acresAMetrosToolStripMenuItem, hectareaAMetrosToolStripMenuItem });
            convercionesToolStripMenuItem.Name = "convercionesToolStripMenuItem";
            convercionesToolStripMenuItem.Size = new Size(89, 20);
            convercionesToolStripMenuItem.Text = "converciones";
            // 
            // centimetroAMetrosToolStripMenuItem
            // 
            centimetroAMetrosToolStripMenuItem.Name = "centimetroAMetrosToolStripMenuItem";
            centimetroAMetrosToolStripMenuItem.Size = new Size(197, 22);
            centimetroAMetrosToolStripMenuItem.Text = "centimetro a metros";
            centimetroAMetrosToolStripMenuItem.Click += centimetroAMetrosToolStripMenuItem_Click;
            // 
            // metrosAKilometrosToolStripMenuItem
            // 
            metrosAKilometrosToolStripMenuItem.Name = "metrosAKilometrosToolStripMenuItem";
            metrosAKilometrosToolStripMenuItem.Size = new Size(197, 22);
            metrosAKilometrosToolStripMenuItem.Text = "metros a kilometros";
            metrosAKilometrosToolStripMenuItem.Click += metrosAKilometrosToolStripMenuItem_Click;
            // 
            // milimetrosAMetrosToolStripMenuItem
            // 
            milimetrosAMetrosToolStripMenuItem.Name = "milimetrosAMetrosToolStripMenuItem";
            milimetrosAMetrosToolStripMenuItem.Size = new Size(197, 22);
            milimetrosAMetrosToolStripMenuItem.Text = "milimetros a metros";
            milimetrosAMetrosToolStripMenuItem.Click += milimetrosAMetrosToolStripMenuItem_Click;
            // 
            // pulgadasACentimetrosToolStripMenuItem
            // 
            pulgadasACentimetrosToolStripMenuItem.Name = "pulgadasACentimetrosToolStripMenuItem";
            pulgadasACentimetrosToolStripMenuItem.Size = new Size(197, 22);
            pulgadasACentimetrosToolStripMenuItem.Text = "pulgadas a centimetros";
            pulgadasACentimetrosToolStripMenuItem.Click += pulgadasACentimetrosToolStripMenuItem_Click;
            // 
            // piesAMetrosToolStripMenuItem
            // 
            piesAMetrosToolStripMenuItem.Name = "piesAMetrosToolStripMenuItem";
            piesAMetrosToolStripMenuItem.Size = new Size(197, 22);
            piesAMetrosToolStripMenuItem.Text = "pies a metros";
            piesAMetrosToolStripMenuItem.Click += piesAMetrosToolStripMenuItem_Click;
            // 
            // yardasAMetrosToolStripMenuItem
            // 
            yardasAMetrosToolStripMenuItem.Name = "yardasAMetrosToolStripMenuItem";
            yardasAMetrosToolStripMenuItem.Size = new Size(197, 22);
            yardasAMetrosToolStripMenuItem.Text = "yardas a metros";
            yardasAMetrosToolStripMenuItem.Click += yardasAMetrosToolStripMenuItem_Click;
            // 
            // acresAMetrosToolStripMenuItem
            // 
            acresAMetrosToolStripMenuItem.Name = "acresAMetrosToolStripMenuItem";
            acresAMetrosToolStripMenuItem.Size = new Size(197, 22);
            acresAMetrosToolStripMenuItem.Text = "acres a metros";
            acresAMetrosToolStripMenuItem.Click += acresAMetrosToolStripMenuItem_Click;
            // 
            // hectareaAMetrosToolStripMenuItem
            // 
            hectareaAMetrosToolStripMenuItem.Name = "hectareaAMetrosToolStripMenuItem";
            hectareaAMetrosToolStripMenuItem.Size = new Size(197, 22);
            hectareaAMetrosToolStripMenuItem.Text = "hectarea a metros";
            hectareaAMetrosToolStripMenuItem.Click += hectareaAMetrosToolStripMenuItem_Click;
            // 
            // creditosToolStripMenuItem
            // 
            creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            creditosToolStripMenuItem.Size = new Size(61, 20);
            creditosToolStripMenuItem.Text = "creditos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 52);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "Proyecto final Unidad 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 115);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 3;
            label2.Text = "alumno: jose manuel ovando veliz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 353);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem convercionesToolStripMenuItem;
        private ToolStripMenuItem centimetroAMetrosToolStripMenuItem;
        private ToolStripMenuItem metrosAKilometrosToolStripMenuItem;
        private ToolStripMenuItem milimetrosAMetrosToolStripMenuItem;
        private ToolStripMenuItem pulgadasACentimetrosToolStripMenuItem;
        private ToolStripMenuItem piesAMetrosToolStripMenuItem;
        private ToolStripMenuItem yardasAMetrosToolStripMenuItem;
        private ToolStripMenuItem acresAMetrosToolStripMenuItem;
        private ToolStripMenuItem hectareaAMetrosToolStripMenuItem;
        private ToolStripMenuItem creditosToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}
