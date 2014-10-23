namespace EragonStructure.UI
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameInput = new System.Windows.Forms.TextBox();
            this.fighterBtn = new System.Windows.Forms.Button();
            this.mageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GothicI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(451, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter player\'s name:";
            // 
            // playerNameInput
            // 
            this.playerNameInput.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.playerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNameInput.Location = new System.Drawing.Point(449, 144);
            this.playerNameInput.Name = "playerNameInput";
            this.playerNameInput.Size = new System.Drawing.Size(345, 35);
            this.playerNameInput.TabIndex = 1;
            // 
            // fighterBtn
            // 
            this.fighterBtn.BackColor = System.Drawing.Color.Transparent;
            this.fighterBtn.FlatAppearance.BorderSize = 0;
            this.fighterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fighterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fighterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fighterBtn.Image = ((System.Drawing.Image)(resources.GetObject("fighterBtn.Image")));
            this.fighterBtn.Location = new System.Drawing.Point(622, 280);
            this.fighterBtn.Name = "fighterBtn";
            this.fighterBtn.Size = new System.Drawing.Size(172, 230);
            this.fighterBtn.TabIndex = 2;
            this.fighterBtn.UseVisualStyleBackColor = false;
            this.fighterBtn.Click += new System.EventHandler(this.fighterBtn_Click);
            // 
            // mageBtn
            // 
            this.mageBtn.BackColor = System.Drawing.Color.Transparent;
            this.mageBtn.FlatAppearance.BorderSize = 0;
            this.mageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mageBtn.Image = ((System.Drawing.Image)(resources.GetObject("mageBtn.Image")));
            this.mageBtn.Location = new System.Drawing.Point(449, 278);
            this.mageBtn.Name = "mageBtn";
            this.mageBtn.Size = new System.Drawing.Size(167, 232);
            this.mageBtn.TabIndex = 3;
            this.mageBtn.UseVisualStyleBackColor = false;
            this.mageBtn.Click += new System.EventHandler(this.mageBtn_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.mageBtn);
            this.Controls.Add(this.fighterBtn);
            this.Controls.Add(this.playerNameInput);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameInput;
        private System.Windows.Forms.Button fighterBtn;
        private System.Windows.Forms.Button mageBtn;
    }
}