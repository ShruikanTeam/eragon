using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EragonStructure.GameObjects;

namespace EragonStructure.UI
{
    public partial class BattleForm : Form
    {
        private Player playerInBattle;
        private Enemy enemyInBattle;

        public BattleForm(Player player, Creature enemy)
        {
            InitializeComponent();
            Painter.GoFullscreen(this, true);
            this.playerInBattle = player;
            this.enemyInBattle = (Enemy)enemy;
            ShowInfo();
        }

        public void ShowInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Player stats:\n");
            info.AppendLine("Name: " + playerInBattle.Name);
            info.AppendLine("Attack value: " + playerInBattle.Attack);
            info.AppendLine("Defence value: " + playerInBattle.Defense);
            info.AppendLine("Health value: " + playerInBattle.CurrentHealthPoints);
            info.AppendLine("Experience: " + playerInBattle.CurrentExperience);
            info.AppendLine("Level: " + playerInBattle.Level);
            PlayerTextBox.Text = info.ToString();

            info.Clear();
            info.AppendLine("Enemy stats:\n");
            info.AppendLine("Name: " + enemyInBattle.Name);
            info.AppendLine("Attack value: " + enemyInBattle.Attack);
            info.AppendLine("Defence value: " + enemyInBattle.Defense);
            info.AppendLine("Health value: " + enemyInBattle.CurrentHealthPoints);
            EnemyTextBox.Text = info.ToString();
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
            enemyInBattle.CurrentHealthPoints -= playerInBattle.Attack - enemyInBattle.Defense;
            if (!enemyInBattle.IsAlive)
            {
                playerInBattle.CurrentExperience += enemyInBattle.MaxHealthPoints;
                DialogResult message = MessageBox.Show("Victory!",
                      "You win!", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            playerInBattle.CurrentHealthPoints -= enemyInBattle.Attack - playerInBattle.Defense;
            if (!playerInBattle.IsAlive)
            {
                DialogResult message = MessageBox.Show("Defeat!",
                      "You have died miserably!", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            ShowInfo();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {

        }

        private void BattleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void chanceBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) <= 20)
            {
                enemyInBattle.CurrentHealthPoints -= 4 * playerInBattle.Attack - enemyInBattle.Defense;
            }

            if (!enemyInBattle.IsAlive)
            {
                playerInBattle.CurrentExperience += enemyInBattle.MaxHealthPoints;
                DialogResult message = MessageBox.Show("Victory!",
                    "You win!", MessageBoxButtons.OK);
                this.Close();
                return;
            }

            playerInBattle.CurrentHealthPoints -= enemyInBattle.Attack - playerInBattle.Defense;
            if (!playerInBattle.IsAlive)
            {
                DialogResult message = MessageBox.Show("Defeat!",
                      "You have died miserably!", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            ShowInfo();
        }
    }
}
