
namespace Seminar4_1058
{
    partial class Form2
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
            this.textBoxMesaje3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMesaje3
            // 
            this.textBoxMesaje3.Enabled = false;
            this.textBoxMesaje3.Location = new System.Drawing.Point(66, 93);
            this.textBoxMesaje3.Multiline = true;
            this.textBoxMesaje3.Name = "textBoxMesaje3";
            this.textBoxMesaje3.Size = new System.Drawing.Size(298, 306);
            this.textBoxMesaje3.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 467);
            this.Controls.Add(this.textBoxMesaje3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMesaje3;
    }
}