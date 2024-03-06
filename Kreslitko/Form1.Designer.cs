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
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.sStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlatno
            // 
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Location = new System.Drawing.Point(66, 64);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(530, 281);
            this.pbPlatno.TabIndex = 0;
            this.pbPlatno.TabStop = false;
            this.pbPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseMove);
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
            this.sStripBottom.Location = new System.Drawing.Point(0, 453);
            this.sStripBottom.Name = "sStripBottom";
            this.sStripBottom.Size = new System.Drawing.Size(795, 22);
            this.sStripBottom.TabIndex = 2;
            this.sStripBottom.Text = "statusStrip1";
            // 
            // tsMysSouradnice
            // 
            this.tsMysSouradnice.Name = "tsMysSouradnice";
            this.tsMysSouradnice.Size = new System.Drawing.Size(46, 17);
            this.tsMysSouradnice.Text = "x: 0 y: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 475);
            this.Controls.Add(this.sStripBottom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbPlatno);
            this.Name = "Form1";
            this.Text = "Kreslení";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.sStripBottom.ResumeLayout(false);
            this.sStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlatno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip sStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel tsMysSouradnice;
    }
}

