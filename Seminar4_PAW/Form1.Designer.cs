
namespace Seminar4_PAW
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpecializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFisiere = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMedici = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdaugaMedic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModificaMedic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergeMedic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPacienti = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdauga = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModifica = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderCNP,
            this.columnHeaderSpecializare,
            this.columnHeaderOrar});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(475, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;

            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 100;
            // 
            // columnHeaderCNP
            // 
            this.columnHeaderCNP.Text = "CNP";
            this.columnHeaderCNP.Width = 84;
            // 
            // columnHeaderSpecializare
            // 
            this.columnHeaderSpecializare.Text = "Specializare";
            this.columnHeaderSpecializare.Width = 100;
            // 
            // columnHeaderOrar
            // 
            this.columnHeaderOrar.Text = "Orar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFisiere,
            this.toolStripMenuItemMedici,
            this.toolStripMenuItemPacienti});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFisiere
            // 
            this.toolStripMenuItemFisiere.Name = "toolStripMenuItemFisiere";
            this.toolStripMenuItemFisiere.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItemFisiere.Text = "Fisiere";
            // 
            // toolStripMenuItemMedici
            // 
            this.toolStripMenuItemMedici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdaugaMedic,
            this.toolStripMenuItemModificaMedic,
            this.toolStripMenuItemStergeMedic});
            this.toolStripMenuItemMedici.Name = "toolStripMenuItemMedici";
            this.toolStripMenuItemMedici.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItemMedici.Text = "Medici";
            // 
            // toolStripMenuItemAdaugaMedic
            // 
            this.toolStripMenuItemAdaugaMedic.Name = "toolStripMenuItemAdaugaMedic";
            this.toolStripMenuItemAdaugaMedic.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAdaugaMedic.Text = "Adauga Medic";
            this.toolStripMenuItemAdaugaMedic.Click += new System.EventHandler(this.toolStripMenuItemAdaugaMedic_Click);
            // 
            // toolStripMenuItemModificaMedic
            // 
            this.toolStripMenuItemModificaMedic.Name = "toolStripMenuItemModificaMedic";
            this.toolStripMenuItemModificaMedic.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemModificaMedic.Text = "Modifica Medic";
            this.toolStripMenuItemModificaMedic.Click += new System.EventHandler(this.toolStripMenuItemModificaMedic_Click);
            // 
            // toolStripMenuItemStergeMedic
            // 
            this.toolStripMenuItemStergeMedic.Name = "toolStripMenuItemStergeMedic";
            this.toolStripMenuItemStergeMedic.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemStergeMedic.Text = "Sterge Medic";
            this.toolStripMenuItemStergeMedic.Click += new System.EventHandler(this.toolStripMenuItemStergeMedic_Click);
            // 
            // toolStripMenuItemPacienti
            // 
            this.toolStripMenuItemPacienti.Name = "toolStripMenuItemPacienti";
            this.toolStripMenuItemPacienti.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemPacienti.Text = "Pacienti";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdauga,
            this.toolStripMenuItemModifica,
            this.toolStripMenuItemSterge});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            // 
            // toolStripMenuItemAdauga
            // 
            this.toolStripMenuItemAdauga.Name = "toolStripMenuItemAdauga";
            this.toolStripMenuItemAdauga.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItemAdauga.Text = "Adauga";
            this.toolStripMenuItemAdauga.Click += new System.EventHandler(this.toolStripMenuItemAdaugaMedic_Click);
            // 
            // toolStripMenuItemModifica
            // 
            this.toolStripMenuItemModifica.Name = "toolStripMenuItemModifica";
            this.toolStripMenuItemModifica.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItemModifica.Text = "Moficica";
            this.toolStripMenuItemModifica.Click += new System.EventHandler(this.toolStripMenuItemModificaMedic_Click);
            // 
            // toolStripMenuItemSterge
            // 
            this.toolStripMenuItemSterge.Name = "toolStripMenuItemSterge";
            this.toolStripMenuItemSterge.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItemSterge.Text = "Sterge";
            this.toolStripMenuItemSterge.Click += new System.EventHandler(this.toolStripMenuItemStergeMedic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 544);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderCNP;
        private System.Windows.Forms.ColumnHeader columnHeaderSpecializare;
        private System.Windows.Forms.ColumnHeader columnHeaderOrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFisiere;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMedici;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdaugaMedic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModificaMedic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeMedic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPacienti;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdauga;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModifica;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSterge;
    }
}

