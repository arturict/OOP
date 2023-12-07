namespace Rechteck
{
    partial class RechteckForms
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
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBreite = new System.Windows.Forms.TextBox();
            this.textBoxHoehe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAusgabe = new System.Windows.Forms.TextBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(570, 64);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(137, 42);
            this.buttonBerechnen.TabIndex = 0;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Breide des Rechetcks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Höhe des Rechtecks";
            // 
            // textBoxBreite
            // 
            this.textBoxBreite.Location = new System.Drawing.Point(163, 64);
            this.textBoxBreite.Name = "textBoxBreite";
            this.textBoxBreite.Size = new System.Drawing.Size(219, 20);
            this.textBoxBreite.TabIndex = 3;
            // 
            // textBoxHoehe
            // 
            this.textBoxHoehe.Location = new System.Drawing.Point(163, 141);
            this.textBoxHoehe.Name = "textBoxHoehe";
            this.textBoxHoehe.Size = new System.Drawing.Size(219, 20);
            this.textBoxHoehe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ausgabe (Fläche)";
            // 
            // textBoxAusgabe
            // 
            this.textBoxAusgabe.Location = new System.Drawing.Point(163, 333);
            this.textBoxAusgabe.Name = "textBoxAusgabe";
            this.textBoxAusgabe.ReadOnly = true;
            this.textBoxAusgabe.Size = new System.Drawing.Size(219, 20);
            this.textBoxAusgabe.TabIndex = 6;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(570, 329);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(137, 41);
            this.buttonBeenden.TabIndex = 7;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // RechteckForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.textBoxAusgabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHoehe);
            this.Controls.Add(this.textBoxBreite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBerechnen);
            this.Name = "RechteckForms";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBreite;
        private System.Windows.Forms.TextBox textBoxHoehe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAusgabe;
        private System.Windows.Forms.Button buttonBeenden;
    }
}

