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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbPszczolka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPszczolka)).BeginInit();
            this.SuspendLayout();
            // 
            // glownyTimer
            // 
            this.glownyTimer.Enabled = true;
            this.glownyTimer.Interval = 20;
            this.glownyTimer.Tick += new System.EventHandler(this.glownyTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(-17, 642);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(838, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbPszczolka
            // 
            this.pbPszczolka.Image = global::Pszczolka.Properties.Resources.prawa_s;
            this.pbPszczolka.Location = new System.Drawing.Point(29, 557);
            this.pbPszczolka.Name = "pbPszczolka";
            this.pbPszczolka.Size = new System.Drawing.Size(85, 85);
            this.pbPszczolka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPszczolka.TabIndex = 0;
            this.pbPszczolka.TabStop = false;
            // 
            // Poziom_pierwszy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1924, 682);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbPszczolka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Poziom_pierwszy";
            this.Text = "Pszczolka";
            this.Load += new System.EventHandler(this.Poziom_pierwszy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Poziom_pierwszy_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Poziom_pierwszy_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPszczolka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPszczolka;
        private System.Windows.Forms.Timer glownyTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}