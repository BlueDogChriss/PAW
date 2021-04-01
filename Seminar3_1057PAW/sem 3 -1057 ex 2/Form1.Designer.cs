namespace sem_3__1057_ex_2
{
    partial class Form1
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
            this.lNume = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.lPrenume = new System.Windows.Forms.Label();
            this.bAfisare = new System.Windows.Forms.Button();
            this.lVarsta = new System.Windows.Forms.Label();
            this.textVarsta = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideAplicatiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNume
            // 
            this.lNume.AutoSize = true;
            this.lNume.Location = new System.Drawing.Point(47, 46);
            this.lNume.Name = "lNume";
            this.lNume.Size = new System.Drawing.Size(38, 13);
            this.lNume.TabIndex = 0;
            this.lNume.Text = "Nume:";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(104, 46);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 1;
            this.textNume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(104, 86);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 2;
            this.textPrenume.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lPrenume
            // 
            this.lPrenume.AutoSize = true;
            this.lPrenume.Location = new System.Drawing.Point(47, 86);
            this.lPrenume.Name = "lPrenume";
            this.lPrenume.Size = new System.Drawing.Size(52, 13);
            this.lPrenume.TabIndex = 3;
            this.lPrenume.Text = "Prenume:";
            // 
            // bAfisare
            // 
            this.bAfisare.Location = new System.Drawing.Point(104, 162);
            this.bAfisare.Name = "bAfisare";
            this.bAfisare.Size = new System.Drawing.Size(75, 23);
            this.bAfisare.TabIndex = 4;
            this.bAfisare.Text = "Afiseaza";
            this.bAfisare.UseVisualStyleBackColor = true;
            this.bAfisare.Click += new System.EventHandler(this.bAfisare_Click);
            // 
            // lVarsta
            // 
            this.lVarsta.AutoSize = true;
            this.lVarsta.Location = new System.Drawing.Point(47, 126);
            this.lVarsta.Name = "lVarsta";
            this.lVarsta.Size = new System.Drawing.Size(37, 13);
            this.lVarsta.TabIndex = 5;
            this.lVarsta.Text = "Varsta";
            // 
            // textVarsta
            // 
            this.textVarsta.Location = new System.Drawing.Point(104, 126);
            this.textVarsta.Name = "textVarsta";
            this.textVarsta.Size = new System.Drawing.Size(100, 20);
            this.textVarsta.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschieToolStripMenuItem,
            this.inchideAplicatiaToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // deschieToolStripMenuItem
            // 
            this.deschieToolStripMenuItem.Name = "deschieToolStripMenuItem";
            this.deschieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deschieToolStripMenuItem.Text = "Deschide";
            // 
            // inchideAplicatiaToolStripMenuItem
            // 
            this.inchideAplicatiaToolStripMenuItem.Name = "inchideAplicatiaToolStripMenuItem";
            this.inchideAplicatiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inchideAplicatiaToolStripMenuItem.Text = "Inchide aplicatia";
            this.inchideAplicatiaToolStripMenuItem.Click += new System.EventHandler(this.inchideAplicatiaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 497);
            this.Controls.Add(this.textVarsta);
            this.Controls.Add(this.lVarsta);
            this.Controls.Add(this.bAfisare);
            this.Controls.Add(this.lPrenume);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.lNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNume;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.Label lPrenume;
        private System.Windows.Forms.Button bAfisare;
        private System.Windows.Forms.Label lVarsta;
        private System.Windows.Forms.TextBox textVarsta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideAplicatiaToolStripMenuItem;
    }
}

