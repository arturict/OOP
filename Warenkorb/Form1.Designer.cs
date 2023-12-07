namespace Warenkorb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabelAnzeigen = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAnzeigeAnz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnzahl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelAnzeigen
            // 
            this.linkLabelAnzeigen.AutoSize = true;
            this.linkLabelAnzeigen.Location = new System.Drawing.Point(180, 68);
            this.linkLabelAnzeigen.Name = "linkLabelAnzeigen";
            this.linkLabelAnzeigen.Size = new System.Drawing.Size(106, 13);
            this.linkLabelAnzeigen.TabIndex = 0;
            this.linkLabelAnzeigen.TabStop = true;
            this.linkLabelAnzeigen.Text = "Warenkorb anzeigen";
            this.linkLabelAnzeigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAnzeigen_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(146, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelAnzeigeAnz
            // 
            this.labelAnzeigeAnz.AutoSize = true;
            this.labelAnzeigeAnz.Location = new System.Drawing.Point(105, 68);
            this.labelAnzeigeAnz.Name = "labelAnzeigeAnz";
            this.labelAnzeigeAnz.Size = new System.Drawing.Size(35, 13);
            this.labelAnzeigeAnz.TabIndex = 2;
            this.labelAnzeigeAnz.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zum Warenkorb hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produkt:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anzahl:";
            // 
            // textBoxAnzahl
            // 
            this.textBoxAnzahl.Location = new System.Drawing.Point(114, 160);
            this.textBoxAnzahl.Name = "textBoxAnzahl";
            this.textBoxAnzahl.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnzahl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 347);
            this.Controls.Add(this.textBoxAnzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAnzeigeAnz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelAnzeigen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelAnzeigen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAnzeigeAnz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAnzahl;
    }
}

