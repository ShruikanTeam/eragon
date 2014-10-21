using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EragonStructure.Enumerations;
using EragonStructure.GameObjects;
using EragonStructure.Structs;
using Point = System.Drawing.Point;

namespace EragonStructure.UI
{
    public partial class Window : Form
    {
        [DllImport("user32")]
        static extern short GetAsyncKeyState(Keys vKey);

        public const int TimeInterval = 30;
        private Bitmap backBuffer;
        private Picture backGround;
        private Picture heroPicture;
        private Picture creepPicture;
        private World world;
        private Fighter hero;
        private Creep creep;

        public Window()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);

            Load += Form1_CreateBackBuffer;
            Paint += Form1_Paint;

            LoadImages();
            world = new World(ClientSize.Width, ClientSize.Height, backGround);
            hero = new Fighter(new Structs.Point(100, 350),
                new EragonStructure.Structs.Size(100, 100),
                heroPicture,
                "bai ivan",
                90, 120, 10, 100, 200, 10, 1, 10);
            creep = new Creep(new Structs.Point(400, 150),
                new EragonStructure.Structs.Size(100, 100),
                creepPicture,
                "creep",
                90, 120, 10, 60, 100, 3);
            
            world.AddObject(creep);
            world.AddObject(hero);

            var windowTimer = new Timer() { Interval = TimeInterval };
            windowTimer.Tick += (s, args) => UpdateScreen();
            windowTimer.Start();
        }

        public void LoadImages()
        {
            string resPath = Directory.GetCurrentDirectory() + @"..\..\..\Resources\";
            try
            {
                backGround = new Picture(new Bitmap(Image.FromFile(resPath + @"Backgrounds\Eragon_Saphira.jpg"), new System.Drawing.Size(ClientSize.Width, ClientSize.Height)));
                heroPicture = new Picture(new Bitmap(Image.FromFile(resPath + @"NiceGuys\archer2.png"), new System.Drawing.Size(80, 100)));
                creepPicture = new Picture(new Bitmap(Image.FromFile(resPath + @"BadGuys\BossIceMonster01.png"), new System.Drawing.Size(100, 100)));
            }
            catch (IOException)
            {
                Console.WriteLine("cannot read from file!");
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (backBuffer != null)
            {
                e.Graphics.DrawImageUnscaled(backBuffer, Point.Empty);
            }
        }

        private void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (backBuffer != null)
                backBuffer.Dispose();

            backBuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        private void CheckKeyInput()
        {
            if (GetAsyncKeyState(Keys.Left) < 0)
            {
                hero.Direction = Direction.West;
                hero.Move();
            }
            if (GetAsyncKeyState(Keys.Right) < 0)
            {
                hero.Direction = Direction.East;
                hero.Move();
            }
            if (GetAsyncKeyState(Keys.Up) < 0)
            {
                hero.Direction = Direction.North;
                hero.Move();
            }
            if (GetAsyncKeyState(Keys.Down) < 0)
            {
                hero.Direction = Direction.South;
                hero.Move();
            }

            //Sample detecting collision with enemy
            if (hero.Point.X.Equals(creep.Point.X + creep.Size.Width / 2) && hero.Point.Y.Equals(creep.Point.Y)
                || hero.Point.X.Equals(creep.Point.X) && hero.Point.Y.Equals(creep.Size.Height / 2)
                || hero.Point.X.Equals(creep.Point.X) && hero.Point.Y.Equals(creep.Point.Y + creep.Size.Height / 2))
            {
                DialogResult message = MessageBox.Show("Are you sure you want to fight?",
                      "Fight ahead!", MessageBoxButtons.YesNo);
                switch (message)
                {
                    case DialogResult.Yes: break;
                    case DialogResult.No: break;
                }
            }
            //Point[] creepPos = {
            //    new Point (creep.Point.X + 50, creep.Point.Y),
            //    new Point (creep.Point.X, creep.Point.Y + 50)
            //    };

            //for (int i = 0; i < creepPos.Length; i++)
            //{
            //    if (hero.Point.Equals(creepPos[i]))
            //    {
            //        DialogResult message = MessageBox.Show("Are you sure you want to fight?",
            //          "Fight ahead!", MessageBoxButtons.YesNo);
            //        switch (message)
            //        {
            //            case DialogResult.Yes: break;
            //            case DialogResult.No: break;
            //        }

            //    }
            //}
        }

        private void UpdateScreen()
        {
            CheckKeyInput();

            if (backBuffer != null)
            {
                using (var g = Graphics.FromImage(backBuffer))
                {
                    world.Draw(g);
                }

                Invalidate();
            }
        }
    }
}
