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
            this.buttonGas = new System.Windows.Forms.Button();
            this.buttonBremsen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPS = new System.Windows.Forms.Label();
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.progressBarTank = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTankProzent = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSchalter = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelKmh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStartC = new System.Windows.Forms.PictureBox();
            this.pictureBoxTanken = new System.Windows.Forms.PictureBox();
            this.pictureBoxHupe = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartCar = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerGas = new System.Windows.Forms.Timer(this.components);
            this.timerBremsen = new System.Windows.Forms.Timer(this.components);
            this.timerTanken = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartCar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGas
            // 
            this.buttonGas.Location = new System.Drawing.Point(491, 144);
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.Size = new System.Drawing.Size(75, 160);
            this.buttonGas.TabIndex = 0;
            this.buttonGas.Text = "Gas";
            this.buttonGas.UseVisualStyleBackColor = true;
            this.buttonGas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGas_MouseDown);
            this.buttonGas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonGas_MouseUp);
            // 
            // buttonBremsen
            // 
            this.buttonBremsen.Location = new System.Drawing.Point(376, 144);
            this.buttonBremsen.Name = "buttonBremsen";
            this.buttonBremsen.Size = new System.Drawing.Size(109, 160);
            this.buttonBremsen.TabIndex = 1;
            this.buttonBremsen.Text = "Bremse";
            this.buttonBremsen.UseVisualStyleBackColor = true;
            this.buttonBremsen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBremsen_MouseDown);
            this.buttonBremsen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonBremsen_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auto wählen";
            // 
            // labelPS
            // 
            this.labelPS.AutoSize = true;
            this.labelPS.Location = new System.Drawing.Point(305, 4);
            this.labelPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPS.Name = "labelPS";
            this.labelPS.Size = new System.Drawing.Size(30, 13);
            this.labelPS.TabIndex = 3;
            this.labelPS.Text = "0 PS";
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(143, 2);
            this.comboBoxAutos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(151, 21);
            this.comboBoxAutos.TabIndex = 4;
            this.comboBoxAutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutos_SelectedIndexChanged);
            // 
            // progressBarTank
            // 
            this.progressBarTank.ForeColor = System.Drawing.Color.Lime;
            this.progressBarTank.Location = new System.Drawing.Point(108, 101);
            this.progressBarTank.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarTank.Name = "progressBarTank";
            this.progressBarTank.Size = new System.Drawing.Size(333, 15);
            this.progressBarTank.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.labelTankProzent);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBarTank);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(114, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(451, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // labelTankProzent
            // 
            this.labelTankProzent.AutoSize = true;
            this.labelTankProzent.ForeColor = System.Drawing.Color.Red;
            this.labelTankProzent.Location = new System.Drawing.Point(45, 101);
            this.labelTankProzent.Name = "labelTankProzent";
            this.labelTankProzent.Size = new System.Drawing.Size(21, 13);
            this.labelTankProzent.TabIndex = 12;
            this.labelTankProzent.Text = "0%";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Image = global::AutoSimulator.Properties.Resources.tankstelle;
            this.pictureBox2.Location = new System.Drawing.Point(83, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Controls.Add(this.labelSchalter);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox4.Location = new System.Drawing.Point(295, 37);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(76, 44);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // labelSchalter
            // 
            this.labelSchalter.AutoSize = true;
            this.labelSchalter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchalter.ForeColor = System.Drawing.Color.Cyan;
            this.labelSchalter.Location = new System.Drawing.Point(28, 14);
            this.labelSchalter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.groupBox3.Location = new System.Drawing.Point(25, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(205, 44);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // labelKmh
            // 
            this.labelKmh.AutoSize = true;
            this.labelKmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmh.ForeColor = System.Drawing.Color.Lime;
            this.labelKmh.Location = new System.Drawing.Point(91, 14);
            this.labelKmh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKmh.Name = "labelKmh";
            this.labelKmh.Size = new System.Drawing.Size(30, 31);
            this.labelKmh.TabIndex = 0;
            this.labelKmh.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(45, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "km/h";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.pictureBoxStartC);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.pictureBoxTanken);
            this.groupBox2.Controls.Add(this.pictureBoxHupe);
            this.groupBox2.Controls.Add(this.pictureBoxStartCar);
            this.groupBox2.Controls.Add(this.buttonBremsen);
            this.groupBox2.Controls.Add(this.buttonGas);
            this.groupBox2.Location = new System.Drawing.Point(5, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(582, 311);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxStartC
            // 
            this.pictureBoxStartC.BackColor = System.Drawing.Color.Red;
            this.pictureBoxStartC.Location = new System.Drawing.Point(91, 21);
            this.pictureBoxStartC.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxStartC.Name = "pictureBoxStartC";
            this.pictureBoxStartC.Size = new System.Drawing.Size(19, 13);
            this.pictureBoxStartC.TabIndex = 8;
            this.pictureBoxStartC.TabStop = false;
            // 
            // pictureBoxTanken
            // 
            this.pictureBoxTanken.Image = global::AutoSimulator.Properties.Resources.tankschlauch;
            this.pictureBoxTanken.Location = new System.Drawing.Point(39, 145);
            this.pictureBoxTanken.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTanken.Name = "pictureBoxTanken";
            this.pictureBoxTanken.Size = new System.Drawing.Size(47, 44);
            this.pictureBoxTanken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTanken.TabIndex = 7;
            this.pictureBoxTanken.TabStop = false;
            this.pictureBoxTanken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTanken_MouseDown);
            this.pictureBoxTanken.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTanken_MouseUp);
            // 
            // pictureBoxHupe
            // 
            this.pictureBoxHupe.Image = global::AutoSimulator.Properties.Resources.hupe;
            this.pictureBoxHupe.Location = new System.Drawing.Point(39, 81);
            this.pictureBoxHupe.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHupe.Name = "pictureBoxHupe";
            this.pictureBoxHupe.Size = new System.Drawing.Size(47, 44);
            this.pictureBoxHupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHupe.TabIndex = 6;
            this.pictureBoxHupe.TabStop = false;
            this.pictureBoxHupe.Click += new System.EventHandler(this.pictureBoxHupe_Click);
            // 
            // pictureBoxStartCar
            // 
            this.pictureBoxStartCar.Image = global::AutoSimulator.Properties.Resources.image_Jvma_ZLVA_transformed;
            this.pictureBoxStartCar.Location = new System.Drawing.Point(39, 21);
            this.pictureBoxStartCar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxStartCar.Name = "pictureBoxStartCar";
            this.pictureBoxStartCar.Size = new System.Drawing.Size(47, 44);
            this.pictureBoxStartCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStartCar.TabIndex = 5;
            this.pictureBoxStartCar.TabStop = false;
            this.pictureBoxStartCar.Click += new System.EventHandler(this.pictureBoxStartCar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cockpit\r\n";
            this.notifyIcon1.Visible = true;
            // 
            // timerGas
            // 
            this.timerGas.Tick += new System.EventHandler(this.timerGas_Tick);
            // 
            // timerBremsen
            // 
            this.timerBremsen.Tick += new System.EventHandler(this.timerBremsen_Tick);
            // 
            // timerTanken
            // 
            this.timerTanken.Tick += new System.EventHandler(this.timerTanken_Tick);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 340);
            this.Controls.Add(this.comboBoxAutos);
            this.Controls.Add(this.labelPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Gui";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.Button buttonBremsen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPS;
        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.PictureBox pictureBoxStartCar;
        private System.Windows.Forms.ProgressBar progressBarTank;
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
        private System.Windows.Forms.PictureBox pictureBoxStartC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerGas;
        private System.Windows.Forms.Timer timerBremsen;
        private System.Windows.Forms.Timer timerTanken;
        private System.Windows.Forms.Label labelTankProzent;
    }
}

