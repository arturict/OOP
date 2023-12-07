namespace ReiseMondDauer
{
    partial class Mond
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
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonHours = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGeschwindigkeit = new System.Windows.Forms.TextBox();
            this.buttonDauerBerechnen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reisedauer zum Mond berechnen";
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Location = new System.Drawing.Point(114, 98);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(79, 24);
            this.radioButtonDays.TabIndex = 1;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "in Tage";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonHours
            // 
            this.radioButtonHours.AutoSize = true;
            this.radioButtonHours.Location = new System.Drawing.Point(278, 98);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(104, 24);
            this.radioButtonHours.TabIndex = 2;
            this.radioButtonHours.TabStop = true;
            this.radioButtonHours.Text = "in Stunden";
            this.radioButtonHours.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geschwindigkeit in km/h:";
            // 
            // textBoxGeschwindigkeit
            // 
            this.textBoxGeschwindigkeit.Location = new System.Drawing.Point(321, 163);
            this.textBoxGeschwindigkeit.Name = "textBoxGeschwindigkeit";
            this.textBoxGeschwindigkeit.Size = new System.Drawing.Size(121, 26);
            this.textBoxGeschwindigkeit.TabIndex = 4;
            // 
            // buttonDauerBerechnen
            // 
            this.buttonDauerBerechnen.Location = new System.Drawing.Point(114, 223);
            this.buttonDauerBerechnen.Name = "buttonDauerBerechnen";
            this.buttonDauerBerechnen.Size = new System.Drawing.Size(328, 40);
            this.buttonDauerBerechnen.TabIndex = 5;
            this.buttonDauerBerechnen.Text = "Reisedauer berechen";
            this.buttonDauerBerechnen.UseVisualStyleBackColor = true;
            this.buttonDauerBerechnen.Click += new System.EventHandler(this.buttonDauerBerechnen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ausgabe Reisedauer:";
            // 
            // textBoxAusgabe
            // 
            this.textBoxAusgabe.Location = new System.Drawing.Point(288, 309);
            this.textBoxAusgabe.Name = "textBoxAusgabe";
            this.textBoxAusgabe.ReadOnly = true;
            this.textBoxAusgabe.Size = new System.Drawing.Size(154, 26);
            this.textBoxAusgabe.TabIndex = 7;
            // 
            // Mond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAusgabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDauerBerechnen);
            this.Controls.Add(this.textBoxGeschwindigkeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonHours);
            this.Controls.Add(this.radioButtonDays);
            this.Controls.Add(this.label1);
            this.Name = "Mond";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.RadioButton radioButtonHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGeschwindigkeit;
        private System.Windows.Forms.Button buttonDauerBerechnen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAusgabe;
    }
}

