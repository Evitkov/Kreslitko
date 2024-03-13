namespace Kreslitko
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPlatno = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sStripBottom = new System.Windows.Forms.StatusStrip();
            this.tsMysSouradnice = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpVyberBarvy = new System.Windows.Forms.GroupBox();
            this.pnColorBlue = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnColorRed = new System.Windows.Forms.Panel();
            this.pnColorBlack = new System.Windows.Forms.Panel();
            this.pnColorWhite = new System.Windows.Forms.Panel();
            this.pnBackColor = new System.Windows.Forms.Panel();
            this.pnForeColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.sStripBottom.SuspendLayout();
            this.gpVyberBarvy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlatno
            // 
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Location = new System.Drawing.Point(39, 124);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(561, 350);
            this.pbPlatno.TabIndex = 0;
            this.pbPlatno.TabStop = false;
            this.pbPlatno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseDown);
            this.pbPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseMove);
            this.pbPlatno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sStripBottom
            // 
            this.sStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMysSouradnice});
            this.sStripBottom.Location = new System.Drawing.Point(0, 485);
            this.sStripBottom.Name = "sStripBottom";
            this.sStripBottom.Size = new System.Drawing.Size(832, 22);
            this.sStripBottom.TabIndex = 2;
            this.sStripBottom.Text = "statusStrip1";
            // 
            // tsMysSouradnice
            // 
            this.tsMysSouradnice.Name = "tsMysSouradnice";
            this.tsMysSouradnice.Size = new System.Drawing.Size(46, 17);
            this.tsMysSouradnice.Text = "x: 0 y: 0";
            // 
            // gpVyberBarvy
            // 
            this.gpVyberBarvy.Controls.Add(this.pnColorBlue);
            this.gpVyberBarvy.Controls.Add(this.panel1);
            this.gpVyberBarvy.Controls.Add(this.pnColorBlack);
            this.gpVyberBarvy.Controls.Add(this.pnColorWhite);
            this.gpVyberBarvy.Controls.Add(this.pnBackColor);
            this.gpVyberBarvy.Controls.Add(this.pnForeColor);
            this.gpVyberBarvy.Location = new System.Drawing.Point(39, 12);
            this.gpVyberBarvy.Name = "gpVyberBarvy";
            this.gpVyberBarvy.Size = new System.Drawing.Size(561, 106);
            this.gpVyberBarvy.TabIndex = 3;
            this.gpVyberBarvy.TabStop = false;
            this.gpVyberBarvy.Text = "Výběr Barvy";
            // 
            // pnColorBlue
            // 
            this.pnColorBlue.BackColor = System.Drawing.Color.Blue;
            this.pnColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorBlue.Location = new System.Drawing.Point(228, 19);
            this.pnColorBlue.Name = "pnColorBlue";
            this.pnColorBlue.Size = new System.Drawing.Size(25, 19);
            this.pnColorBlue.TabIndex = 5;
            this.pnColorBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnColorRed);
            this.panel1.Location = new System.Drawing.Point(197, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 19);
            this.panel1.TabIndex = 4;
            // 
            // pnColorRed
            // 
            this.pnColorRed.BackColor = System.Drawing.Color.Red;
            this.pnColorRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorRed.Location = new System.Drawing.Point(-2, -2);
            this.pnColorRed.Name = "pnColorRed";
            this.pnColorRed.Size = new System.Drawing.Size(25, 19);
            this.pnColorRed.TabIndex = 4;
            this.pnColorRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorBlack
            // 
            this.pnColorBlack.BackColor = System.Drawing.Color.Black;
            this.pnColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorBlack.Location = new System.Drawing.Point(166, 19);
            this.pnColorBlack.Name = "pnColorBlack";
            this.pnColorBlack.Size = new System.Drawing.Size(25, 19);
            this.pnColorBlack.TabIndex = 3;
            this.pnColorBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorWhite
            // 
            this.pnColorWhite.BackColor = System.Drawing.Color.White;
            this.pnColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorWhite.Location = new System.Drawing.Point(134, 19);
            this.pnColorWhite.Name = "pnColorWhite";
            this.pnColorWhite.Size = new System.Drawing.Size(26, 19);
            this.pnColorWhite.TabIndex = 2;
            this.pnColorWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnBackColor
            // 
            this.pnBackColor.BackColor = System.Drawing.Color.White;
            this.pnBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBackColor.Location = new System.Drawing.Point(6, 61);
            this.pnBackColor.Name = "pnBackColor";
            this.pnBackColor.Size = new System.Drawing.Size(35, 26);
            this.pnBackColor.TabIndex = 1;
            // 
            // pnForeColor
            // 
            this.pnForeColor.BackColor = System.Drawing.Color.Black;
            this.pnForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnForeColor.Location = new System.Drawing.Point(6, 29);
            this.pnForeColor.Name = "pnForeColor";
            this.pnForeColor.Size = new System.Drawing.Size(35, 26);
            this.pnForeColor.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 507);
            this.Controls.Add(this.gpVyberBarvy);
            this.Controls.Add(this.sStripBottom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbPlatno);
            this.Name = "Form1";
            this.Text = "Kreslení";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.sStripBottom.ResumeLayout(false);
            this.sStripBottom.PerformLayout();
            this.gpVyberBarvy.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlatno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip sStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel tsMysSouradnice;
        private System.Windows.Forms.GroupBox gpVyberBarvy;
        private System.Windows.Forms.Panel pnColorBlack;
        private System.Windows.Forms.Panel pnColorWhite;
        private System.Windows.Forms.Panel pnBackColor;
        private System.Windows.Forms.Panel pnForeColor;
        private System.Windows.Forms.Panel pnColorBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnColorRed;
    }
}

