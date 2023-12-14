namespace Tannenbaum
{
    partial class TannenbaumForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBaumErstellen = new System.Windows.Forms.Button();
            this.textBoxStamm = new System.Windows.Forms.TextBox();
            this.textBoxStammhoehe = new System.Windows.Forms.TextBox();
            this.textBoxKrone = new System.Windows.Forms.TextBox();
            this.textBoxAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammbreite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stammhöhe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kronenhöhe";
            // 
            // buttonBaumErstellen
            // 
            this.buttonBaumErstellen.Location = new System.Drawing.Point(570, 107);
            this.buttonBaumErstellen.Name = "buttonBaumErstellen";
            this.buttonBaumErstellen.Size = new System.Drawing.Size(174, 63);
            this.buttonBaumErstellen.TabIndex = 3;
            this.buttonBaumErstellen.Text = "Tanne erstellen";
            this.buttonBaumErstellen.UseVisualStyleBackColor = true;
            this.buttonBaumErstellen.Click += new System.EventHandler(this.buttonBaumErstellen_Click);
            // 
            // textBoxStamm
            // 
            this.textBoxStamm.Location = new System.Drawing.Point(206, 6);
            this.textBoxStamm.Name = "textBoxStamm";
            this.textBoxStamm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxStamm.Size = new System.Drawing.Size(148, 26);
            this.textBoxStamm.TabIndex = 4;
            // 
            // textBoxStammhoehe
            // 
            this.textBoxStammhoehe.Location = new System.Drawing.Point(206, 67);
            this.textBoxStammhoehe.Name = "textBoxStammhoehe";
            this.textBoxStammhoehe.Size = new System.Drawing.Size(148, 26);
            this.textBoxStammhoehe.TabIndex = 5;
            // 
            // textBoxKrone
            // 
            this.textBoxKrone.Location = new System.Drawing.Point(206, 121);
            this.textBoxKrone.Name = "textBoxKrone";
            this.textBoxKrone.Size = new System.Drawing.Size(148, 26);
            this.textBoxKrone.TabIndex = 6;
            // 
            // textBoxAusgabe
            // 
            this.textBoxAusgabe.Location = new System.Drawing.Point(86, 184);
            this.textBoxAusgabe.Multiline = true;
            this.textBoxAusgabe.Name = "textBoxAusgabe";
            this.textBoxAusgabe.ReadOnly = true;
            this.textBoxAusgabe.Size = new System.Drawing.Size(546, 505);
            this.textBoxAusgabe.TabIndex = 7;
            // 
            // TannenbaumForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 740);
            this.Controls.Add(this.textBoxAusgabe);
            this.Controls.Add(this.textBoxKrone);
            this.Controls.Add(this.textBoxStammhoehe);
            this.Controls.Add(this.textBoxStamm);
            this.Controls.Add(this.buttonBaumErstellen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TannenbaumForms";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBaumErstellen;
        private System.Windows.Forms.TextBox textBoxStamm;
        private System.Windows.Forms.TextBox textBoxStammhoehe;
        private System.Windows.Forms.TextBox textBoxKrone;
        private System.Windows.Forms.TextBox textBoxAusgabe;
    }
}

