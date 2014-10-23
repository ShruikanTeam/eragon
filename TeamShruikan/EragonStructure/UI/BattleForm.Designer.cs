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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.attackBtn = new System.Windows.Forms.Button();
            this.chanceBtn = new System.Windows.Forms.Button();
            this.PlayerTextBox = new System.Windows.Forms.TextBox();
            this.EnemyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // attackBtn
            // 
            this.attackBtn.Location = new System.Drawing.Point(135, 440);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(75, 23);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.AttackBtn_Click);
            // 
            // chanceBtn
            // 
            this.chanceBtn.Location = new System.Drawing.Point(273, 440);
            this.chanceBtn.Name = "chanceBtn";
            this.chanceBtn.Size = new System.Drawing.Size(75, 23);
            this.chanceBtn.TabIndex = 1;
            this.chanceBtn.Text = "Chance";
            this.chanceBtn.UseVisualStyleBackColor = true;
            this.chanceBtn.Click += new System.EventHandler(this.chanceBtn_Click);
            // 
            // PlayerTextBox
            // 
            this.PlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTextBox.Location = new System.Drawing.Point(62, 84);
            this.PlayerTextBox.Multiline = true;
            this.PlayerTextBox.Name = "PlayerTextBox";
            this.PlayerTextBox.Size = new System.Drawing.Size(215, 271);
            this.PlayerTextBox.TabIndex = 2;
            // 
            // EnemyTextBox
            // 
            this.EnemyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyTextBox.Location = new System.Drawing.Point(479, 84);
            this.EnemyTextBox.Multiline = true;
            this.EnemyTextBox.Name = "EnemyTextBox";
            this.EnemyTextBox.Size = new System.Drawing.Size(215, 271);
            this.EnemyTextBox.TabIndex = 3;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.EnemyTextBox);
            this.Controls.Add(this.PlayerTextBox);
            this.Controls.Add(this.chanceBtn);
            this.Controls.Add(this.attackBtn);
            this.Name = "BattleForm";
            this.Text = "BattleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BattleForm_FormClosing);
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button chanceBtn;
        private System.Windows.Forms.TextBox PlayerTextBox;
        private System.Windows.Forms.TextBox EnemyTextBox;
    }
}