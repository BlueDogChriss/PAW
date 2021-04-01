
namespace Seminar4_1058
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
            this.buttonSeteaza = new System.Windows.Forms.Button();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.buttonCupleaza = new System.Windows.Forms.Button();
            this.buttonDecupleaza = new System.Windows.Forms.Button();
            this.textBoxMesaje1 = new System.Windows.Forms.TextBox();
            this.textBoxMesaje2 = new System.Windows.Forms.TextBox();
            this.buttonForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSeteaza
            // 
            this.buttonSeteaza.Location = new System.Drawing.Point(286, 67);
            this.buttonSeteaza.Name = "buttonSeteaza";
            this.buttonSeteaza.Size = new System.Drawing.Size(132, 23);
            this.buttonSeteaza.TabIndex = 0;
            this.buttonSeteaza.Text = "Seteaza valoare";
            this.buttonSeteaza.UseVisualStyleBackColor = true;
            this.buttonSeteaza.Click += new System.EventHandler(this.buttonSeteaza_Click);
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(69, 69);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(100, 20);
            this.textBoxInt.TabIndex = 1;
            // 
            // buttonCupleaza
            // 
            this.buttonCupleaza.Location = new System.Drawing.Point(286, 118);
            this.buttonCupleaza.Name = "buttonCupleaza";
            this.buttonCupleaza.Size = new System.Drawing.Size(132, 23);
            this.buttonCupleaza.TabIndex = 2;
            this.buttonCupleaza.Text = "Cupleaza";
            this.buttonCupleaza.UseVisualStyleBackColor = true;
            this.buttonCupleaza.Click += new System.EventHandler(this.buttonCupleaza_Click);
            // 
            // buttonDecupleaza
            // 
            this.buttonDecupleaza.Location = new System.Drawing.Point(286, 179);
            this.buttonDecupleaza.Name = "buttonDecupleaza";
            this.buttonDecupleaza.Size = new System.Drawing.Size(132, 23);
            this.buttonDecupleaza.TabIndex = 3;
            this.buttonDecupleaza.Text = "Decupleaza";
            this.buttonDecupleaza.UseVisualStyleBackColor = true;
            this.buttonDecupleaza.Click += new System.EventHandler(this.buttonDecupleaza_Click);
            // 
            // textBoxMesaje1
            // 
            this.textBoxMesaje1.Enabled = false;
            this.textBoxMesaje1.Location = new System.Drawing.Point(55, 277);
            this.textBoxMesaje1.Multiline = true;
            this.textBoxMesaje1.Name = "textBoxMesaje1";
            this.textBoxMesaje1.Size = new System.Drawing.Size(236, 200);
            this.textBoxMesaje1.TabIndex = 4;
            this.textBoxMesaje1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxMesaje2
            // 
            this.textBoxMesaje2.Enabled = false;
            this.textBoxMesaje2.Location = new System.Drawing.Point(496, 277);
            this.textBoxMesaje2.Multiline = true;
            this.textBoxMesaje2.Name = "textBoxMesaje2";
            this.textBoxMesaje2.Size = new System.Drawing.Size(264, 187);
            this.textBoxMesaje2.TabIndex = 5;
            // 
            // buttonForm2
            // 
            this.buttonForm2.Location = new System.Drawing.Point(621, 82);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(151, 36);
            this.buttonForm2.TabIndex = 6;
            this.buttonForm2.Text = "Deschide form 2";
            this.buttonForm2.UseVisualStyleBackColor = true;
            this.buttonForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 509);
            this.Controls.Add(this.buttonForm2);
            this.Controls.Add(this.textBoxMesaje2);
            this.Controls.Add(this.textBoxMesaje1);
            this.Controls.Add(this.buttonDecupleaza);
            this.Controls.Add(this.buttonCupleaza);
            this.Controls.Add(this.textBoxInt);
            this.Controls.Add(this.buttonSeteaza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeteaza;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.Button buttonCupleaza;
        private System.Windows.Forms.Button buttonDecupleaza;
        private System.Windows.Forms.TextBox textBoxMesaje1;
        private System.Windows.Forms.TextBox textBoxMesaje2;
        private System.Windows.Forms.Button buttonForm2;
    }
}

