namespace EragonStructure.UI
{
    partial class BattleForm
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
            this.attackBtn = new System.Windows.Forms.Button();
            this.chanceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attackBtn
            // 
            this.attackBtn.Location = new System.Drawing.Point(111, 404);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(75, 23);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // chanceBtn
            // 
            this.chanceBtn.Location = new System.Drawing.Point(249, 404);
            this.chanceBtn.Name = "chanceBtn";
            this.chanceBtn.Size = new System.Drawing.Size(75, 23);
            this.chanceBtn.TabIndex = 1;
            this.chanceBtn.Text = "Chance";
            this.chanceBtn.UseVisualStyleBackColor = true;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.chanceBtn);
            this.Controls.Add(this.attackBtn);
            this.Name = "BattleForm";
            this.Text = "BattleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button chanceBtn;
    }
}