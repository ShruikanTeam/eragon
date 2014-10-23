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
        private List<GameObject> gameObjects;
        private Player player;
        private Creature enemy;
        private BasicAttack item;
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
            gameObjects = new List<GameObject>();
            //InitializeCharacters();
            State = "start";
        }

        private void InitializeCharacters()
        {
            if (UserInput.PlayerType == "fighter")
            {
                player = new Fighter(new Structs.Point(100, 350),
                    new EragonStructure.Structs.Size(painter.FighterPicture.Size.Width, painter.FighterPicture.Size.Height),
                    painter.FighterPicture,
                    UserInput.PlayerName,
                    90, 120, 10, 130, 200, 10, 1, 10, true);
            }
            else if (UserInput.PlayerType == "mage")
            {
                player = new Mage(new Structs.Point(100, 400),
                    new EragonStructure.Structs.Size(painter.MagePicture.Size.Width, painter.MagePicture.Size.Height),
                    painter.MagePicture,
                    UserInput.PlayerName,
                    90, 120, 10, 130, 200, 10, 1, 10, true);
            }

            gameObjects.Add(player);
            gameObjects.Add(new Creep(new Structs.Point(200, 150),
                new EragonStructure.Structs.Size(painter.CreepPicture.Size.Width, painter.CreepPicture.Size.Height),
                painter.CreepPicture,
                "Creep",
                60, 30, 10, 60, 100, 3));
            gameObjects.Add(new Creep(new Structs.Point(100, 200),
                new EragonStructure.Structs.Size(painter.SkeletonPicture.Size.Width, painter.SkeletonPicture.Size.Height),
                painter.SkeletonPicture,
                "Skelton",
                80, 20, 10, 60, 100, 3));
            gameObjects.Add(new Creep(new Structs.Point(300, 350),
                new EragonStructure.Structs.Size(painter.CreepPicture.Size.Width, painter.CreepPicture.Size.Height),
                painter.CreepPicture,
                "Trol",
                40, 20, 10, 60, 100, 3));
            gameObjects.Add(new Creep(new Structs.Point(500, 450),
                new EragonStructure.Structs.Size(painter.SkeletonPicture.Size.Width, painter.SkeletonPicture.Size.Height),
                painter.SkeletonPicture,
                "skeleton",
                60, 30, 10, 60, 100, 3));
            gameObjects.Add(new Creep(new Structs.Point(800, 600),
                new EragonStructure.Structs.Size(painter.CreepPicture.Size.Width, painter.CreepPicture.Size.Height),
                painter.CreepPicture,
                "Creep",
                50, 40, 10, 60, 100, 3));
            gameObjects.Add(new Boss(new Structs.Point(800, 100),
                new EragonStructure.Structs.Size(painter.BossPicture.Size.Width, painter.BossPicture.Size.Height),
                painter.BossPicture,
                "Boss",
                120, 20, 10, 60, 100, 3));
            GameObject bow = new BasicAttack(new Structs.Point(600, 500), new EragonStructure.Structs.Size(painter.BowPicture.Size.Width, painter.BowPicture.Size.Height), painter.BowPicture, BasicAttackItemNames.GoldenBow);
            gameObjects.Add(bow);
        }

        public void Play()
        {
            switch (State)
            {
                case "start":
                    if (painter.Window.Visible)
                    {
                        painter.Window.Visible = false;
                        WelcomeForm welcomeForm = new WelcomeForm();
                        welcomeForm.ShowDialog();
                        InitializeCharacters();
                        painter.Window.Visible = true;
                        State = "map";
                    }
                    break;

                case "map":
                    controller.CheckKeyInput();
                    DetectColision();
                    RedrawAll();
                    break;

                case "askBattle":
                    State = "menu";
                    DialogResult message = MessageBox.Show("Are you sure you want to fight?", "Fight ahead!", MessageBoxButtons.YesNo);
                    switch (message)
                    {
                        case DialogResult.Yes:
                            State = "battle";
                            break;
                        case DialogResult.No:
                            int directionOffsetX = player.Point.X.CompareTo(enemy.Point.X);
                            int directionOffsetY = player.Point.Y.CompareTo(enemy.Point.Y);
                            player.Point = new EragonStructure.Structs.Point(
                                player.Point.X + directionOffsetX * (int)(player.Size.Width * 0.2),
                                player.Point.Y + directionOffsetY * (int)(player.Size.Height * 0.2));
                            State = "map";
                            break;
                    }
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
                        gameObjects.Remove(enemy);
                        State = "map";
                    }
                    break;
                case "item":
                    State = "map";
                    gameObjects.Remove(item);
                    MessageBox.Show("You picked an item", "Congrats!", MessageBoxButtons.OK);
                    
                    break;
                case "idle":
                    break;
            }

        }

        private void DetectColision()
        {
            Rectangle playerRect = new Rectangle(player.Point.X, player.Point.Y, player.Size.Width, player.Size.Height);
            foreach (var gameObject in gameObjects)
            {
                if (gameObject is Enemy)
                {
                    Rectangle enemyRect = new Rectangle(gameObject.Point.X, gameObject.Point.Y, gameObject.Size.Width, gameObject.Size.Height);
                    if (playerRect.IntersectsWith(enemyRect))
                    {
                        painter.Window.Text = "battle!!!";
                        State = "askBattle";
                        enemy = (Creature)gameObject;
                    }
                }

                if (gameObject is InventoryItem)
                {
                    if (gameObject is AttackInventoryItem)
                    {
                        Rectangle itemRect = new Rectangle(gameObject.Point.X, gameObject.Point.Y, gameObject.Size.Width, gameObject.Size.Height);
                        if (playerRect.IntersectsWith(itemRect))
                        {
                            painter.Window.Text = "Item found!";
                            player.Attack += (int)((AttackInventoryItem)gameObject).AttackValue;
                            item = (BasicAttack)gameObject;
                            State = "item";
                        }
                        
                    }
                }
            }
        }

        private void RedrawAll()
        {
            painter.Update();
            if (gameObjects.Count > 0)
            {
                foreach (var gameObject in gameObjects)
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
