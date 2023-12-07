namespace Wuerfel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWuerfeln = new System.Windows.Forms.Button();
            this.LabelAktuellerWurf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelLetzterWurf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWuerfeln
            // 
            this.buttonWuerfeln.Location = new System.Drawing.Point(62, 83);
            this.buttonWuerfeln.Name = "buttonWuerfeln";
            this.buttonWuerfeln.Size = new System.Drawing.Size(279, 155);
            this.buttonWuerfeln.TabIndex = 0;
            this.buttonWuerfeln.Text = "Würfeln";
            this.buttonWuerfeln.UseVisualStyleBackColor = true;
            this.buttonWuerfeln.Click += new System.EventHandler(this.buttonWuerfeln_Click);
            // 
            // LabelAktuellerWurf
            // 
            this.LabelAktuellerWurf.AutoSize = true;
            this.LabelAktuellerWurf.Location = new System.Drawing.Point(552, 135);
            this.LabelAktuellerWurf.Name = "LabelAktuellerWurf";
            this.LabelAktuellerWurf.Size = new System.Drawing.Size(105, 20);
            this.LabelAktuellerWurf.TabIndex = 1;
            this.LabelAktuellerWurf.Text = "AktuellerWurf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Letzter Wurf: ";
            // 
            // LabelLetzterWurf
            // 
            this.LabelLetzterWurf.AutoSize = true;
            this.LabelLetzterWurf.Location = new System.Drawing.Point(202, 375);
            this.LabelLetzterWurf.Name = "LabelLetzterWurf";
            this.LabelLetzterWurf.Size = new System.Drawing.Size(105, 20);
            this.LabelLetzterWurf.TabIndex = 3;
            this.LabelLetzterWurf.Text = "letzerter Wurf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelLetzterWurf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelAktuellerWurf);
            this.Controls.Add(this.buttonWuerfeln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWuerfeln;
        private System.Windows.Forms.Label LabelAktuellerWurf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelLetzterWurf;
    }
}

