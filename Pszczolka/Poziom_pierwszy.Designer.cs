namespace Pszczolka
{
    partial class Poziom_pierwszy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poziom_pierwszy));
            this.glownyTimer = new System.Windows.Forms.Timer(this.components);
            this.lWynik = new System.Windows.Forms.Label();
            this.platforma2 = new System.Windows.Forms.PictureBox();
            this.pbPszczolka = new System.Windows.Forms.PictureBox();
            this.pbUl = new System.Windows.Forms.PictureBox();
            this.platforma1 = new System.Windows.Forms.PictureBox();
            this.tlo = new System.Windows.Forms.PictureBox();
            this.platforma3 = new System.Windows.Forms.PictureBox();
            this.platforma7 = new System.Windows.Forms.PictureBox();
            this.platforma4 = new System.Windows.Forms.PictureBox();
            this.platforma5 = new System.Windows.Forms.PictureBox();
            this.platforma6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.platforma2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPszczolka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma6)).BeginInit();
            this.SuspendLayout();
            // 
            // glownyTimer
            // 
            this.glownyTimer.Enabled = true;
            this.glownyTimer.Interval = 20;
            this.glownyTimer.Tick += new System.EventHandler(this.glownyTimer_Tick);
            // 
            // lWynik
            // 
            this.lWynik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lWynik.AutoSize = true;
            this.lWynik.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWynik.ForeColor = System.Drawing.Color.Gray;
            this.lWynik.Location = new System.Drawing.Point(1255, 9);
            this.lWynik.Name = "lWynik";
            this.lWynik.Size = new System.Drawing.Size(124, 21);
            this.lWynik.TabIndex = 5;
            this.lWynik.Text = "Monety: 10";
            // 
            // platforma2
            // 
            this.platforma2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma2.Cursor = System.Windows.Forms.Cursors.Default;
            this.platforma2.Image = global::Pszczolka.Properties.Resources.platforma_bgv2;
            this.platforma2.Location = new System.Drawing.Point(235, 386);
            this.platforma2.Name = "platforma2";
            this.platforma2.Size = new System.Drawing.Size(234, 50);
            this.platforma2.TabIndex = 4;
            this.platforma2.TabStop = false;
            this.platforma2.Tag = "";
            // 
            // pbPszczolka
            // 
            this.pbPszczolka.BackColor = System.Drawing.Color.Black;
            this.pbPszczolka.Image = global::Pszczolka.Properties.Resources.prawa_s;
            this.pbPszczolka.Location = new System.Drawing.Point(46, 465);
            this.pbPszczolka.Name = "pbPszczolka";
            this.pbPszczolka.Size = new System.Drawing.Size(85, 85);
            this.pbPszczolka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPszczolka.TabIndex = 0;
            this.pbPszczolka.TabStop = false;
            // 
            // pbUl
            // 
            this.pbUl.BackColor = System.Drawing.Color.Transparent;
            this.pbUl.Image = global::Pszczolka.Properties.Resources.ul;
            this.pbUl.Location = new System.Drawing.Point(36, 34);
            this.pbUl.Name = "pbUl";
            this.pbUl.Size = new System.Drawing.Size(95, 95);
            this.pbUl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUl.TabIndex = 3;
            this.pbUl.TabStop = false;
            // 
            // platforma1
            // 
            this.platforma1.BackColor = System.Drawing.Color.Black;
            this.platforma1.Image = global::Pszczolka.Properties.Resources.platforma_bgv2;
            this.platforma1.Location = new System.Drawing.Point(0, 546);
            this.platforma1.Name = "platforma1";
            this.platforma1.Size = new System.Drawing.Size(1400, 54);
            this.platforma1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platforma1.TabIndex = 1;
            this.platforma1.TabStop = false;
            this.platforma1.Tag = "platforma";
            // 
            // tlo
            // 
            this.tlo.Image = global::Pszczolka.Properties.Resources.tlo_pierwszy;
            this.tlo.Location = new System.Drawing.Point(0, 0);
            this.tlo.Name = "tlo";
            this.tlo.Size = new System.Drawing.Size(1400, 600);
            this.tlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tlo.TabIndex = 2;
            this.tlo.TabStop = false;
            // 
            // platforma3
            // 
            this.platforma3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma3.Cursor = System.Windows.Forms.Cursors.Default;
            this.platforma3.Image = global::Pszczolka.Properties.Resources.platforma_bgv2;
            this.platforma3.Location = new System.Drawing.Point(525, 321);
            this.platforma3.Name = "platforma3";
            this.platforma3.Size = new System.Drawing.Size(272, 50);
            this.platforma3.TabIndex = 6;
            this.platforma3.TabStop = false;
            this.platforma3.Tag = "";
            // 
            // platforma7
            // 
            this.platforma7.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma7.Cursor = System.Windows.Forms.Cursors.Default;
            this.platforma7.Image = global::Pszczolka.Properties.Resources.platforma_bgv2;
            this.platforma7.Location = new System.Drawing.Point(36, 135);
            this.platforma7.Name = "platforma7";
            this.platforma7.Size = new System.Drawing.Size(343, 50);
            this.platforma7.TabIndex = 7;
            this.platforma7.TabStop = false;
            this.platforma7.Tag = "";
            // 
            // platforma4
            // 
            this.platforma4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma4.Cursor = System.Windows.Forms.Cursors.Default;
            this.platforma4.Image = global::Pszczolka.Properties.Resources.platforma_bgv2;
            this.platforma4.Location = new System.Drawing.Point(868, 386);
            this.platforma4.Name = "platforma4";
            this.platforma4.Size = new System.Drawing.Size(272, 50);
            this.platforma4.TabIndex = 8;
            this.platforma4.TabStop = false;
            this.platforma4.Tag = "";
            // 
            // platforma5
            // 
            this.platforma5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma5.Cursor = System.Windows.Forms.Cursors.Default;
            this.platforma5.Image = global::Pszczolka.Properties.Resources.platforma_bgv2;
            this.platforma5.Location = new System.Drawing.Point(1107, 241);
            this.platforma5.Name = "platforma5";
            this.platforma5.Size = new System.Drawing.Size(272, 50);
            this.platforma5.TabIndex = 9;
            this.platforma5.TabStop = false;
            this.platforma5.Tag = "";
            // 
            // platforma6
            // 
            this.platforma6.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma6.Cursor = System.Windows.Forms.Cursors.Default;
            this.platforma6.Image = global::Pszczolka.Properties.Resources.platforma_bgv2;
            this.platforma6.Location = new System.Drawing.Point(504, 108);
            this.platforma6.Name = "platforma6";
            this.platforma6.Size = new System.Drawing.Size(347, 50);
            this.platforma6.TabIndex = 10;
            this.platforma6.TabStop = false;
            this.platforma6.Tag = "";
            // 
            // Poziom_pierwszy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1391, 595);
            this.Controls.Add(this.platforma6);
            this.Controls.Add(this.platforma5);
            this.Controls.Add(this.platforma4);
            this.Controls.Add(this.platforma7);
            this.Controls.Add(this.platforma3);
            this.Controls.Add(this.lWynik);
            this.Controls.Add(this.platforma2);
            this.Controls.Add(this.pbPszczolka);
            this.Controls.Add(this.pbUl);
            this.Controls.Add(this.platforma1);
            this.Controls.Add(this.tlo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Poziom_pierwszy";
            this.Text = "Pszczolka";
            this.Load += new System.EventHandler(this.Poziom_pierwszy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Poziom_pierwszy_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Poziom_pierwszy_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.platforma2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPszczolka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPszczolka;
        private System.Windows.Forms.Timer glownyTimer;
        private System.Windows.Forms.PictureBox platforma1;
        private System.Windows.Forms.PictureBox pbUl;
        private System.Windows.Forms.PictureBox tlo;
        private System.Windows.Forms.PictureBox platforma2;
        private System.Windows.Forms.Label lWynik;
        private System.Windows.Forms.PictureBox platforma3;
        private System.Windows.Forms.PictureBox platforma7;
        private System.Windows.Forms.PictureBox platforma4;
        private System.Windows.Forms.PictureBox platforma5;
        private System.Windows.Forms.PictureBox platforma6;
    }
}