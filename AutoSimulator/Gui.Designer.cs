namespace AutoSimulator
{
    partial class Gui
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPS = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSchalter = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelKmh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTanken = new System.Windows.Forms.PictureBox();
            this.pictureBoxHupe = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartCar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartCar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 246);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 246);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bremse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auto wählen";
            // 
            // labelPS
            // 
            this.labelPS.AutoSize = true;
            this.labelPS.Location = new System.Drawing.Point(457, 6);
            this.labelPS.Name = "labelPS";
            this.labelPS.Size = new System.Drawing.Size(43, 20);
            this.labelPS.TabIndex = 3;
            this.labelPS.Text = "0 PS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(162, 155);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(171, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Controls.Add(this.labelSchalter);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox4.Location = new System.Drawing.Point(443, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 67);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // labelSchalter
            // 
            this.labelSchalter.AutoSize = true;
            this.labelSchalter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchalter.ForeColor = System.Drawing.Color.Cyan;
            this.labelSchalter.Location = new System.Drawing.Point(42, 22);
            this.labelSchalter.Name = "labelSchalter";
            this.labelSchalter.Size = new System.Drawing.Size(32, 33);
            this.labelSchalter.TabIndex = 1;
            this.labelSchalter.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.labelKmh);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Location = new System.Drawing.Point(37, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 67);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // labelKmh
            // 
            this.labelKmh.AutoSize = true;
            this.labelKmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmh.ForeColor = System.Drawing.Color.Lime;
            this.labelKmh.Location = new System.Drawing.Point(136, 22);
            this.labelKmh.Name = "labelKmh";
            this.labelKmh.Size = new System.Drawing.Size(30, 31);
            this.labelKmh.TabIndex = 0;
            this.labelKmh.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(68, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "km/h";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.pictureBoxTanken);
            this.groupBox2.Controls.Add(this.pictureBoxHupe);
            this.groupBox2.Controls.Add(this.pictureBoxStartCar);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(7, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(873, 478);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cockpit\r\n";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(137, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Image = global::AutoSimulator.Properties.Resources.tankstelle;
            this.pictureBox2.Location = new System.Drawing.Point(124, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxTanken
            // 
            this.pictureBoxTanken.Image = global::AutoSimulator.Properties.Resources.tankschlauch;
            this.pictureBoxTanken.Location = new System.Drawing.Point(59, 223);
            this.pictureBoxTanken.Name = "pictureBoxTanken";
            this.pictureBoxTanken.Size = new System.Drawing.Size(71, 68);
            this.pictureBoxTanken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTanken.TabIndex = 7;
            this.pictureBoxTanken.TabStop = false;
            // 
            // pictureBoxHupe
            // 
            this.pictureBoxHupe.Image = global::AutoSimulator.Properties.Resources.hupe;
            this.pictureBoxHupe.Location = new System.Drawing.Point(59, 124);
            this.pictureBoxHupe.Name = "pictureBoxHupe";
            this.pictureBoxHupe.Size = new System.Drawing.Size(71, 68);
            this.pictureBoxHupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHupe.TabIndex = 6;
            this.pictureBoxHupe.TabStop = false;
            this.pictureBoxHupe.Click += new System.EventHandler(this.pictureBoxHupe_Click);
            // 
            // pictureBoxStartCar
            // 
            this.pictureBoxStartCar.Image = global::AutoSimulator.Properties.Resources.image_Jvma_ZLVA_transformed;
            this.pictureBoxStartCar.Location = new System.Drawing.Point(59, 32);
            this.pictureBoxStartCar.Name = "pictureBoxStartCar";
            this.pictureBoxStartCar.Size = new System.Drawing.Size(71, 68);
            this.pictureBoxStartCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStartCar.TabIndex = 5;
            this.pictureBoxStartCar.TabStop = false;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 523);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gui";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxStartCar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxHupe;
        private System.Windows.Forms.PictureBox pictureBoxTanken;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelSchalter;
        private System.Windows.Forms.Label labelKmh;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

