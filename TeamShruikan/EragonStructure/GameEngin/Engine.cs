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
using EragonStructure.UI;
using EragonStructure.Enumerations;

namespace EragonStructure.GameEngin
{
    public class Engine
    {
        private List<GameObject> creatures;
        private Player player;
        private KeyboardController controller;

        private Painter painter;

        public Engine(KeyboardController controller, Painter painter)
        {
            this.painter = painter;
            this.controller = controller;
            SubscribeToUserInput(controller);
            creatures = new List<GameObject>();
            InitializeCharacters();
        }

        private void InitializeCharacters()
        {
            player = new Fighter(new Structs.Point(100, 350),
                new EragonStructure.Structs.Size(100, 100),
                painter.HeroPicture,
                "Archo",
                90, 120, 10, 100, 200, 10, 1, 10);
            creatures.Add(player);
            creatures.Add(new Creep(new Structs.Point(400, 150),
                new EragonStructure.Structs.Size(100, 100),
                painter.CreepPicture,
                "creep",
                90, 120, 10, 60, 100, 3));
        }

        public void Play()
        {
            controller.CheckKeyInput();
            RedrawAll();    
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
            player.Direction = Direction.East;
            player.Move();
        }

        private void MovePlayerLeft()
        {
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
