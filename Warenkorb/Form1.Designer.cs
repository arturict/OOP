﻿namespace Warenkorb
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
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuswahl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formAnzahl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAnzahl)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelAnzeigen
            // 
            this.linkLabelAnzeigen.AutoSize = true;
            this.linkLabelAnzeigen.Location = new System.Drawing.Point(270, 105);
            this.linkLabelAnzeigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelAnzeigen.Name = "linkLabelAnzeigen";
            this.linkLabelAnzeigen.Size = new System.Drawing.Size(156, 20);
            this.linkLabelAnzeigen.TabIndex = 0;
            this.linkLabelAnzeigen.TabStop = true;
            this.linkLabelAnzeigen.Text = "Warenkorb anzeigen";
            this.linkLabelAnzeigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAnzeigen_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(219, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelAnzeigeAnz
            // 
            this.labelAnzeigeAnz.AutoSize = true;
            this.labelAnzeigeAnz.Location = new System.Drawing.Point(158, 105);
            this.labelAnzeigeAnz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnzeigeAnz.Name = "labelAnzeigeAnz";
            this.labelAnzeigeAnz.Size = new System.Drawing.Size(28, 20);
            this.labelAnzeigeAnz.TabIndex = 2;
            this.labelAnzeigeAnz.Text = "(0)";
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(171, 328);
            this.buttonHinzufügen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(258, 55);
            this.buttonHinzufügen.TabIndex = 3;
            this.buttonHinzufügen.Text = "Zum Warenkorb hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produkt:";
            // 
            // comboBoxAuswahl
            // 
            this.comboBoxAuswahl.FormattingEnabled = true;
            this.comboBoxAuswahl.Location = new System.Drawing.Point(171, 192);
            this.comboBoxAuswahl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxAuswahl.Name = "comboBoxAuswahl";
            this.comboBoxAuswahl.Size = new System.Drawing.Size(282, 28);
            this.comboBoxAuswahl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anzahl:";
            // 
            // formAnzahl
            // 
            this.formAnzahl.Location = new System.Drawing.Point(171, 246);
            this.formAnzahl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formAnzahl.Name = "formAnzahl";
            this.formAnzahl.Size = new System.Drawing.Size(90, 26);
            this.formAnzahl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 534);
            this.Controls.Add(this.formAnzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAuswahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHinzufügen);
            this.Controls.Add(this.labelAnzeigeAnz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelAnzeigen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAnzahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelAnzeigen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAnzeigeAnz;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuswahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown formAnzahl;
    }
}

