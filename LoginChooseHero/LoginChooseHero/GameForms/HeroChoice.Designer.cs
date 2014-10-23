namespace LoginChooseHero.GameForms
{
    partial class HeroChoice
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
            this.archer = new System.Windows.Forms.PictureBox();
            this.ninja = new System.Windows.Forms.PictureBox();
            this.iceMage = new System.Windows.Forms.PictureBox();
            this.redKnight = new System.Windows.Forms.PictureBox();
            this.viking = new System.Windows.Forms.PictureBox();
            this.iceWitch = new System.Windows.Forms.PictureBox();
            this.lbChooce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.archer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceMage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceWitch)).BeginInit();
            this.SuspendLayout();
            // 
            // archer
            // 
            this.archer.BackColor = System.Drawing.Color.Transparent;
            this.archer.Image = global::LoginChooseHero.Properties.Resources.Archer;
            this.archer.Location = new System.Drawing.Point(69, 72);
            this.archer.Name = "archer";
            this.archer.Size = new System.Drawing.Size(120, 180);
            this.archer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.archer.TabIndex = 0;
            this.archer.TabStop = false;
            // 
            // ninja
            // 
            this.ninja.BackColor = System.Drawing.Color.Transparent;
            this.ninja.Image = global::LoginChooseHero.Properties.Resources.Ninja;
            this.ninja.Location = new System.Drawing.Point(259, 72);
            this.ninja.Name = "ninja";
            this.ninja.Size = new System.Drawing.Size(120, 180);
            this.ninja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ninja.TabIndex = 1;
            this.ninja.TabStop = false;
            // 
            // iceMage
            // 
            this.iceMage.BackColor = System.Drawing.Color.Transparent;
            this.iceMage.Image = global::LoginChooseHero.Properties.Resources.IceMage;
            this.iceMage.Location = new System.Drawing.Point(47, 268);
            this.iceMage.Name = "iceMage";
            this.iceMage.Size = new System.Drawing.Size(173, 180);
            this.iceMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iceMage.TabIndex = 2;
            this.iceMage.TabStop = false;
            // 
            // redKnight
            // 
            this.redKnight.BackColor = System.Drawing.Color.Transparent;
            this.redKnight.Image = global::LoginChooseHero.Properties.Resources.RedKnight;
            this.redKnight.Location = new System.Drawing.Point(259, 268);
            this.redKnight.Name = "redKnight";
            this.redKnight.Size = new System.Drawing.Size(120, 180);
            this.redKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redKnight.TabIndex = 3;
            this.redKnight.TabStop = false;
            // 
            // viking
            // 
            this.viking.BackColor = System.Drawing.Color.Transparent;
            this.viking.Image = global::LoginChooseHero.Properties.Resources.Viking;
            this.viking.Location = new System.Drawing.Point(47, 454);
            this.viking.Name = "viking";
            this.viking.Size = new System.Drawing.Size(173, 201);
            this.viking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viking.TabIndex = 4;
            this.viking.TabStop = false;
            // 
            // iceWitch
            // 
            this.iceWitch.BackColor = System.Drawing.Color.Transparent;
            this.iceWitch.Image = global::LoginChooseHero.Properties.Resources.IceWitch;
            this.iceWitch.Location = new System.Drawing.Point(226, 454);
            this.iceWitch.Name = "iceWitch";
            this.iceWitch.Size = new System.Drawing.Size(188, 201);
            this.iceWitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iceWitch.TabIndex = 5;
            this.iceWitch.TabStop = false;
            // 
            // lbChooce
            // 
            this.lbChooce.AutoSize = true;
            this.lbChooce.BackColor = System.Drawing.Color.Transparent;
            this.lbChooce.Font = new System.Drawing.Font("Algerian", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooce.ForeColor = System.Drawing.Color.DarkRed;
            this.lbChooce.Location = new System.Drawing.Point(471, 72);
            this.lbChooce.Name = "lbChooce";
            this.lbChooce.Size = new System.Drawing.Size(539, 60);
            this.lbChooce.TabIndex = 6;
            this.lbChooce.Text = "Chooce Your Hero";
            // 
            // HeroChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginChooseHero.Properties.Resources.CastleAtSea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Controls.Add(this.lbChooce);
            this.Controls.Add(this.iceWitch);
            this.Controls.Add(this.viking);
            this.Controls.Add(this.redKnight);
            this.Controls.Add(this.iceMage);
            this.Controls.Add(this.ninja);
            this.Controls.Add(this.archer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HeroChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroChoice";
            ((System.ComponentModel.ISupportInitialize)(this.archer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceMage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceWitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox archer;
        private System.Windows.Forms.PictureBox ninja;
        private System.Windows.Forms.PictureBox iceMage;
        private System.Windows.Forms.PictureBox redKnight;
        private System.Windows.Forms.PictureBox viking;
        private System.Windows.Forms.PictureBox iceWitch;
        private System.Windows.Forms.Label lbChooce;
    }
}