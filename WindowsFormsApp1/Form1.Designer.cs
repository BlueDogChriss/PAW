
namespace WindowsFormsApp1
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
            this.labelNume = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.butonAfiseaza = new System.Windows.Forms.Button();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.textVarsta = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideAplicatiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxIntA = new System.Windows.Forms.TextBox();
            this.textBoxIntB = new System.Windows.Forms.TextBox();
            this.ButonSchimbaOperatia = new System.Windows.Forms.Button();
            this.labelOperatiaCurenta = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(41, 35);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(106, 34);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 1;
            // 
            // butonAfiseaza
            // 
            this.butonAfiseaza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butonAfiseaza.Location = new System.Drawing.Point(119, 142);
            this.butonAfiseaza.Name = "butonAfiseaza";
            this.butonAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.butonAfiseaza.TabIndex = 2;
            this.butonAfiseaza.Text = "POC!";
            this.butonAfiseaza.UseVisualStyleBackColor = true;
            this.butonAfiseaza.Click += new System.EventHandler(this.butonAfiseaza_Click);
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(41, 69);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 3;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Location = new System.Drawing.Point(41, 100);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(37, 13);
            this.labelVarsta.TabIndex = 4;
            this.labelVarsta.Text = "Varsta";
            // 
            // textVarsta
            // 
            this.textVarsta.Location = new System.Drawing.Point(106, 98);
            this.textVarsta.Name = "textVarsta";
            this.textVarsta.Size = new System.Drawing.Size(100, 20);
            this.textVarsta.TabIndex = 5;
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(106, 66);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 6;
            this.textPrenume.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideToolStripMenuItem,
            this.inchideAplicatiaToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deschideToolStripMenuItem.Text = "Deschide";
            this.deschideToolStripMenuItem.Click += new System.EventHandler(this.deschideToolStripMenuItem_Click);
            // 
            // inchideAplicatiaToolStripMenuItem
            // 
            this.inchideAplicatiaToolStripMenuItem.Name = "inchideAplicatiaToolStripMenuItem";
            this.inchideAplicatiaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inchideAplicatiaToolStripMenuItem.Text = "Inchide Aplicatia";
            this.inchideAplicatiaToolStripMenuItem.Click += new System.EventHandler(this.inchideAplicatiaToolStripMenuItem_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // textBoxIntA
            // 
            this.textBoxIntA.Location = new System.Drawing.Point(471, 97);
            this.textBoxIntA.Name = "textBoxIntA";
            this.textBoxIntA.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntA.TabIndex = 8;
            // 
            // textBoxIntB
            // 
            this.textBoxIntB.Location = new System.Drawing.Point(643, 97);
            this.textBoxIntB.Name = "textBoxIntB";
            this.textBoxIntB.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntB.TabIndex = 9;
            // 
            // ButonSchimbaOperatia
            // 
            this.ButonSchimbaOperatia.Location = new System.Drawing.Point(643, 173);
            this.ButonSchimbaOperatia.Name = "ButonSchimbaOperatia";
            this.ButonSchimbaOperatia.Size = new System.Drawing.Size(111, 23);
            this.ButonSchimbaOperatia.TabIndex = 10;
            this.ButonSchimbaOperatia.Text = "Schimba Operatia";
            this.ButonSchimbaOperatia.UseVisualStyleBackColor = true;
            this.ButonSchimbaOperatia.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOperatiaCurenta
            // 
            this.labelOperatiaCurenta.AutoSize = true;
            this.labelOperatiaCurenta.Location = new System.Drawing.Point(471, 173);
            this.labelOperatiaCurenta.Name = "labelOperatiaCurenta";
            this.labelOperatiaCurenta.Size = new System.Drawing.Size(47, 13);
            this.labelOperatiaCurenta.TabIndex = 11;
            this.labelOperatiaCurenta.Text = "Adunare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 581);
            this.Controls.Add(this.labelOperatiaCurenta);
            this.Controls.Add(this.ButonSchimbaOperatia);
            this.Controls.Add(this.textBoxIntB);
            this.Controls.Add(this.textBoxIntA);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textVarsta);
            this.Controls.Add(this.labelVarsta);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.butonAfiseaza);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.labelNume);
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

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.Button butonAfiseaza;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.TextBox textVarsta;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideAplicatiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxIntA;
        private System.Windows.Forms.TextBox textBoxIntB;
        private System.Windows.Forms.Button ButonSchimbaOperatia;
        private System.Windows.Forms.Label labelOperatiaCurenta;
    }
}

