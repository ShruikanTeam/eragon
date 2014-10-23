using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EragonStructure.GameObjects;

namespace EragonStructure.UI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            Painter.GoFullscreen(this, true);
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            LoadResources();
        }

        public void LoadResources()
        {
            string resPath = Directory.GetCurrentDirectory() + @"..\..\..\Resources\";
            try
            {
                var backGround = new Bitmap(Image.FromFile(resPath + @"Backgrounds\WelcomeScreen.png"), new System.Drawing.Size(this.Width, this.Height));
                this.BackgroundImage = backGround;
                this.Invalidate();
            }
            catch (IOException)
            {
                Console.WriteLine("cannot read from file!");
            }
        }

        private void fighterBtn_Click(object sender, EventArgs e)
        {
            if (playerNameInput.Text.Length < 3)
            {
                DialogResult message = MessageBox.Show("Please, enter name longer than 3 symbols!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                UserInput.PlayerName = playerNameInput.Text;
                UserInput.PlayerType = "fighter";
                this.Dispose();
            }

        }

        private void mageBtn_Click(object sender, EventArgs e)
        {
            if (playerNameInput.Text.Length < 3)
            {
                DialogResult message = MessageBox.Show("Error", "Please, enter name longer than 3 symbols!", MessageBoxButtons.OK);
            }
            else
            {
                UserInput.PlayerName = playerNameInput.Text;
                UserInput.PlayerType = "mage";
                this.Dispose();
            }
        }

        
    }
}
