
namespace Seminar4_PAW
{
    partial class FormMedic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.comboBoxAnAbsolvire = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecializare = new System.Windows.Forms.ComboBox();
            this.buttonActualizare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataNasterii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "An absolvire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Specializare";
            // 
            // dateTimePickerDataNasterii
            // 
            this.dateTimePickerDataNasterii.Location = new System.Drawing.Point(175, 80);
            this.dateTimePickerDataNasterii.Name = "dateTimePickerDataNasterii";
            this.dateTimePickerDataNasterii.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataNasterii.TabIndex = 5;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(175, 28);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(200, 20);
            this.textBoxNume.TabIndex = 6;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(175, 132);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(200, 20);
            this.textBoxCNP.TabIndex = 7;
            // 
            // comboBoxAnAbsolvire
            // 
            this.comboBoxAnAbsolvire.FormattingEnabled = true;
            this.comboBoxAnAbsolvire.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.comboBoxAnAbsolvire.Location = new System.Drawing.Point(175, 184);
            this.comboBoxAnAbsolvire.Name = "comboBoxAnAbsolvire";
            this.comboBoxAnAbsolvire.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnAbsolvire.TabIndex = 8;
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Items.AddRange(new object[] {
            "Neurolog",
            "Cardiolog",
            "Oftalmolog",
            "Pneumolog",
            "Ortoped",
            "Oncolog"});
            this.comboBoxSpecializare.Location = new System.Drawing.Point(175, 236);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSpecializare.TabIndex = 9;
            // 
            // buttonActualizare
            // 
            this.buttonActualizare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonActualizare.Location = new System.Drawing.Point(207, 314);
            this.buttonActualizare.Name = "buttonActualizare";
            this.buttonActualizare.Size = new System.Drawing.Size(121, 32);
            this.buttonActualizare.TabIndex = 10;
            this.buttonActualizare.Text = "Actualizare";
            this.buttonActualizare.UseVisualStyleBackColor = true;
            this.buttonActualizare.Click += new System.EventHandler(this.buttonActualizare_Click);
            // 
            // FormMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.buttonActualizare);
            this.Controls.Add(this.comboBoxSpecializare);
            this.Controls.Add(this.comboBoxAnAbsolvire);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.dateTimePickerDataNasterii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMedic";
            this.Text = "FormMedic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasterii;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.ComboBox comboBoxAnAbsolvire;
        private System.Windows.Forms.ComboBox comboBoxSpecializare;
        public System.Windows.Forms.Button buttonActualizare;
    }
}