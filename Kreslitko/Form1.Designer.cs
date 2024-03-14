﻿namespace Kreslitko
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
            this.pnColorOrange = new System.Windows.Forms.Panel();
            this.pnColorRed = new System.Windows.Forms.Panel();
            this.pnColorBlue = new System.Windows.Forms.Panel();
            this.pnColorSalmon = new System.Windows.Forms.Panel();
            this.pnColorOlive = new System.Windows.Forms.Panel();
            this.pnColorGrey = new System.Windows.Forms.Panel();
            this.pnColorDarkRed = new System.Windows.Forms.Panel();
            this.pnColorLime = new System.Windows.Forms.Panel();
            this.pnColorGreen = new System.Windows.Forms.Panel();
            this.pnColorPurple = new System.Windows.Forms.Panel();
            this.pnColorPink = new System.Windows.Forms.Panel();
            this.pnColorCyan = new System.Windows.Forms.Panel();
            this.pnColorNavy = new System.Windows.Forms.Panel();
            this.pnColorBlack = new System.Windows.Forms.Panel();
            this.pnColorWhite = new System.Windows.Forms.Panel();
            this.pnBackColor = new System.Windows.Forms.Panel();
            this.pnForeColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.sStripBottom.SuspendLayout();
            this.gpVyberBarvy.SuspendLayout();
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
            this.gpVyberBarvy.Controls.Add(this.pnColorOrange);
            this.gpVyberBarvy.Controls.Add(this.pnColorRed);
            this.gpVyberBarvy.Controls.Add(this.pnColorBlue);
            this.gpVyberBarvy.Controls.Add(this.pnColorSalmon);
            this.gpVyberBarvy.Controls.Add(this.pnColorOlive);
            this.gpVyberBarvy.Controls.Add(this.pnColorGrey);
            this.gpVyberBarvy.Controls.Add(this.pnColorDarkRed);
            this.gpVyberBarvy.Controls.Add(this.pnColorLime);
            this.gpVyberBarvy.Controls.Add(this.pnColorGreen);
            this.gpVyberBarvy.Controls.Add(this.pnColorPurple);
            this.gpVyberBarvy.Controls.Add(this.pnColorPink);
            this.gpVyberBarvy.Controls.Add(this.pnColorCyan);
            this.gpVyberBarvy.Controls.Add(this.pnColorNavy);
            this.gpVyberBarvy.Controls.Add(this.pnColorBlack);
            this.gpVyberBarvy.Controls.Add(this.pnColorWhite);
            this.gpVyberBarvy.Controls.Add(this.pnBackColor);
            this.gpVyberBarvy.Controls.Add(this.pnForeColor);
            this.gpVyberBarvy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpVyberBarvy.Location = new System.Drawing.Point(39, 12);
            this.gpVyberBarvy.Name = "gpVyberBarvy";
            this.gpVyberBarvy.Size = new System.Drawing.Size(561, 106);
            this.gpVyberBarvy.TabIndex = 3;
            this.gpVyberBarvy.TabStop = false;
            this.gpVyberBarvy.Text = "Výběr Barvy";
            // 
            // pnColorOrange
            // 
            this.pnColorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnColorOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorOrange.Location = new System.Drawing.Point(193, 46);
            this.pnColorOrange.Name = "pnColorOrange";
            this.pnColorOrange.Size = new System.Drawing.Size(25, 19);
            this.pnColorOrange.TabIndex = 7;
            this.pnColorOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorRed
            // 
            this.pnColorRed.BackColor = System.Drawing.Color.Red;
            this.pnColorRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorRed.Location = new System.Drawing.Point(162, 46);
            this.pnColorRed.Name = "pnColorRed";
            this.pnColorRed.Size = new System.Drawing.Size(25, 19);
            this.pnColorRed.TabIndex = 4;
            this.pnColorRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorBlue
            // 
            this.pnColorBlue.BackColor = System.Drawing.Color.Blue;
            this.pnColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorBlue.Location = new System.Drawing.Point(224, 46);
            this.pnColorBlue.Name = "pnColorBlue";
            this.pnColorBlue.Size = new System.Drawing.Size(25, 19);
            this.pnColorBlue.TabIndex = 14;
            this.pnColorBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorSalmon
            // 
            this.pnColorSalmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnColorSalmon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorSalmon.Location = new System.Drawing.Point(162, 21);
            this.pnColorSalmon.Name = "pnColorSalmon";
            this.pnColorSalmon.Size = new System.Drawing.Size(25, 19);
            this.pnColorSalmon.TabIndex = 12;
            this.pnColorSalmon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorOlive
            // 
            this.pnColorOlive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnColorOlive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorOlive.Location = new System.Drawing.Point(131, 71);
            this.pnColorOlive.Name = "pnColorOlive";
            this.pnColorOlive.Size = new System.Drawing.Size(25, 19);
            this.pnColorOlive.TabIndex = 11;
            this.pnColorOlive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorGrey
            // 
            this.pnColorGrey.BackColor = System.Drawing.Color.Gray;
            this.pnColorGrey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorGrey.Location = new System.Drawing.Point(100, 46);
            this.pnColorGrey.Name = "pnColorGrey";
            this.pnColorGrey.Size = new System.Drawing.Size(25, 19);
            this.pnColorGrey.TabIndex = 10;
            this.pnColorGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorDarkRed
            // 
            this.pnColorDarkRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnColorDarkRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorDarkRed.Location = new System.Drawing.Point(162, 71);
            this.pnColorDarkRed.Name = "pnColorDarkRed";
            this.pnColorDarkRed.Size = new System.Drawing.Size(25, 19);
            this.pnColorDarkRed.TabIndex = 9;
            this.pnColorDarkRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorLime
            // 
            this.pnColorLime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnColorLime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorLime.Location = new System.Drawing.Point(131, 21);
            this.pnColorLime.Name = "pnColorLime";
            this.pnColorLime.Size = new System.Drawing.Size(25, 19);
            this.pnColorLime.TabIndex = 8;
            this.pnColorLime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorGreen
            // 
            this.pnColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnColorGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorGreen.Location = new System.Drawing.Point(131, 46);
            this.pnColorGreen.Name = "pnColorGreen";
            this.pnColorGreen.Size = new System.Drawing.Size(25, 19);
            this.pnColorGreen.TabIndex = 6;
            this.pnColorGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorPurple
            // 
            this.pnColorPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnColorPurple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorPurple.Location = new System.Drawing.Point(193, 71);
            this.pnColorPurple.Name = "pnColorPurple";
            this.pnColorPurple.Size = new System.Drawing.Size(25, 19);
            this.pnColorPurple.TabIndex = 6;
            this.pnColorPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorPink
            // 
            this.pnColorPink.BackColor = System.Drawing.Color.Magenta;
            this.pnColorPink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorPink.Location = new System.Drawing.Point(193, 21);
            this.pnColorPink.Name = "pnColorPink";
            this.pnColorPink.Size = new System.Drawing.Size(25, 19);
            this.pnColorPink.TabIndex = 7;
            this.pnColorPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorCyan
            // 
            this.pnColorCyan.BackColor = System.Drawing.Color.Cyan;
            this.pnColorCyan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorCyan.Location = new System.Drawing.Point(224, 21);
            this.pnColorCyan.Name = "pnColorCyan";
            this.pnColorCyan.Size = new System.Drawing.Size(25, 19);
            this.pnColorCyan.TabIndex = 6;
            this.pnColorCyan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorNavy
            // 
            this.pnColorNavy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnColorNavy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorNavy.Location = new System.Drawing.Point(224, 71);
            this.pnColorNavy.Name = "pnColorNavy";
            this.pnColorNavy.Size = new System.Drawing.Size(25, 19);
            this.pnColorNavy.TabIndex = 5;
            this.pnColorNavy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorBlack
            // 
            this.pnColorBlack.BackColor = System.Drawing.Color.Black;
            this.pnColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorBlack.Location = new System.Drawing.Point(100, 71);
            this.pnColorBlack.Name = "pnColorBlack";
            this.pnColorBlack.Size = new System.Drawing.Size(25, 19);
            this.pnColorBlack.TabIndex = 3;
            this.pnColorBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorWhite
            // 
            this.pnColorWhite.BackColor = System.Drawing.Color.White;
            this.pnColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorWhite.Location = new System.Drawing.Point(99, 21);
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
        private System.Windows.Forms.Panel pnColorNavy;
        private System.Windows.Forms.Panel pnColorRed;
        private System.Windows.Forms.Panel pnColorBlue;
        private System.Windows.Forms.Panel pnColorOrange;
        private System.Windows.Forms.Panel pnColorSalmon;
        private System.Windows.Forms.Panel pnColorOlive;
        private System.Windows.Forms.Panel pnColorGrey;
        private System.Windows.Forms.Panel pnColorDarkRed;
        private System.Windows.Forms.Panel pnColorLime;
        private System.Windows.Forms.Panel pnColorGreen;
        private System.Windows.Forms.Panel pnColorPurple;
        private System.Windows.Forms.Panel pnColorPink;
        private System.Windows.Forms.Panel pnColorCyan;
    }
}

