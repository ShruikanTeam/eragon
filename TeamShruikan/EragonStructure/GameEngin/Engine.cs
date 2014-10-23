using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EragonStructure.GameObjects;
using EragonStructure.Interfaces;
using EragonStructure.Structs;
using EragonStructure.UI;
using EragonStructure.Enumerations;

namespace EragonStructure.GameEngin
{
    public class Engine
    {
        private List<Creature> creatures;
        private Player player;
        private Creature enemy;
        private KeyboardController controller;
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private Painter painter;

        public Engine(KeyboardController controller, Painter painter)
        {
            this.painter = painter;
            this.controller = controller;
            SubscribeToUserInput(controller);
            creatures = new List<Creature>();
            InitializeCharacters();
            State = "map";
        }

        private void InitializeCharacters()
        {
            player = new Fighter(new Structs.Point(100, 350),
                new EragonStructure.Structs.Size(painter.HeroPicture.Size.Width, painter.HeroPicture.Size.Height),
                painter.HeroPicture,
                "Archo",
                90, 120, 10, 130, 200, 10, 1, 10, true);
            creatures.Add(player);
            creatures.Add(new Creep(new Structs.Point(100, 150),
                new EragonStructure.Structs.Size(painter.CreepPicture.Size.Width, painter.CreepPicture.Size.Height),
                painter.CreepPicture,
                "creep",
                60, 30, 10, 60, 100, 3));
            creatures.Add(new Creep(new Structs.Point(300, 300),
                new EragonStructure.Structs.Size(painter.CreepPicture.Size.Width, painter.CreepPicture.Size.Height),
                painter.CreepPicture,
                "creep",
                80, 20, 10, 60, 100, 3));
            creatures.Add(new Creep(new Structs.Point(500, 400),
                new EragonStructure.Structs.Size(painter.CreepPicture.Size.Width, painter.CreepPicture.Size.Height),
                painter.CreepPicture,
                "creep",
                120, 20, 10, 60, 100, 3));
        }

        public void Play()
        {
            switch (State)
            {
                case "map":
                    controller.CheckKeyInput();
                    DetectColision();
                    RedrawAll();
                    break;
                case "battle":
                    if (painter.Window.Visible)
                    {
                        player.CurrentHealthPoints = player.MaxHealthPoints;
                        painter.Window.Visible = false;
                        BattleForm formBattle = new BattleForm(player, enemy);
                        formBattle.ShowDialog();
                        if (!player.IsAlive)
                        {
                            painter.Window.Close();
                            return;
                        }
                        painter.Window.Visible = true;
                        creatures.Remove(enemy);
                        State = "map";
                    }
                    break;
                case "menu":
                    break;
                case "idle":
                    break;
                case "askBattle":
                    State = "menu";
                    DialogResult message = MessageBox.Show("Are you sure you want to fight?",
                      "Fight ahead!", MessageBoxButtons.YesNo);
                            switch (message)
                            {
                                case DialogResult.Yes:
                                    State = "battle";
                                    break;
                                case DialogResult.No:
                                    int directionOffset = player.Point.X.CompareTo(enemy.Point.X);
                                    player.Point = new EragonStructure.Structs.Point(player.Point.X + directionOffset * (int)(player.Size.Width * 0.5), player.Point.Y);
                                    
                                    State = "map";
                                    break;
                            }
                    break;
            }

        }

        private void DetectColision()
        {
            Rectangle playerRect = new Rectangle(player.Point.X, player.Point.Y, player.Size.Width, player.Size.Height);
            foreach (var creature in creatures)
            {
                if (creature is Enemy)
                {
                    Rectangle enemyRect = new Rectangle(creature.Point.X, creature.Point.Y, creature.Size.Width, creature.Size.Height);
                    if (playerRect.IntersectsWith(enemyRect))
                    {
                        painter.Window.Text = "battle!!!";
                        State = "askBattle";
                        enemy = creature;
                    }
                }
            }
        }

        private void RedrawAll()
        {
            painter.Update();
            if (creatures.Count > 0)
            {
                foreach (var gameObject in creatures)
                {
                    gameObject.Draw(Graphics.FromImage(painter.Canvas));
                    painter.Window.Invalidate();
                }
            }
        }

        private void SubscribeToUserInput(IUserInput userInteface)
        {
            userInteface.OnUpPressed += (sender, args) => MovePlayerUp();
            userInteface.OnDownPressed += (sender, args) => MovePlayerDown();
            userInteface.OnLeftPressed += (sender, args) => MovePlayerLeft();
            userInteface.OnRightPressed += (sender, args) => MovePlayerRight();
        }

        private void MovePlayerRight()
        {
            if (player.ImageDirection)
            {
                player.ImageDirection = !player.ImageDirection;
                player.Picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            
            player.Direction = Direction.East;
            player.Move();
        }

        private void MovePlayerLeft()
        {
            if (!player.ImageDirection)
            {
                player.ImageDirection = !player.ImageDirection;
                player.Picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }

            player.Direction = Direction.West;
            player.Move();
        }

        private void MovePlayerDown()
        {
            player.Direction = Direction.South;
            player.Move();
        }

        private void MovePlayerUp()
        {
            player.Direction = Direction.North;
            player.Move();
        }
    }
}
