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
            this.pbUl = new System.Windows.Forms.PictureBox();
            this.platforma1 = new System.Windows.Forms.PictureBox();
            this.pbPszczolka = new System.Windows.Forms.PictureBox();
            this.tlo = new System.Windows.Forms.PictureBox();
            this.platforma2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPszczolka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma2)).BeginInit();
            this.SuspendLayout();
            // 
            // glownyTimer
            // 
            this.glownyTimer.Enabled = true;
            this.glownyTimer.Interval = 20;
            this.glownyTimer.Tick += new System.EventHandler(this.glownyTimer_Tick);
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
            this.platforma1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma1.Location = new System.Drawing.Point(0, 550);
            this.platforma1.Name = "platforma1";
            this.platforma1.Size = new System.Drawing.Size(1400, 50);
            this.platforma1.TabIndex = 1;
            this.platforma1.TabStop = false;
            this.platforma1.Tag = "platforma";
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
            // tlo
            // 
            this.tlo.Image = global::Pszczolka.Properties.Resources._0RI5Vpn;
            this.tlo.Location = new System.Drawing.Point(0, 0);
            this.tlo.Name = "tlo";
            this.tlo.Size = new System.Drawing.Size(1400, 600);
            this.tlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tlo.TabIndex = 2;
            this.tlo.TabStop = false;
            // 
            // platforma2
            // 
            this.platforma2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.platforma2.Location = new System.Drawing.Point(237, 413);
            this.platforma2.Name = "platforma2";
            this.platforma2.Size = new System.Drawing.Size(200, 50);
            this.platforma2.TabIndex = 4;
            this.platforma2.TabStop = false;
            this.platforma2.Tag = "platforma";
            // 
            // Poziom_pierwszy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1391, 595);
            this.Controls.Add(this.platforma2);
            this.Controls.Add(this.pbPszczolka);
            this.Controls.Add(this.pbUl);
            this.Controls.Add(this.platforma1);
            this.Controls.Add(this.tlo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Poziom_pierwszy";
            this.Text = "Pszczolka";
            this.Load += new System.EventHandler(this.Poziom_pierwszy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Poziom_pierwszy_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Poziom_pierwszy_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbUl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPszczolka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platforma2)).EndInit();
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
    }
}