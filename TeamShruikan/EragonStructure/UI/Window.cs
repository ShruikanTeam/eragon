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
using EragonStructure.GameEngin;
using EragonStructure.GameObjects;
using EragonStructure.Interfaces;
using EragonStructure.Structs;
using Point = System.Drawing.Point;

namespace EragonStructure.UI
{
    public partial class Window : Form
    {
        [DllImport("user32")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);

        public const int TimeInterval = 30;
        //private Bitmap backBuffer;
        private Painter painter;
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

            Paint += Form1_Paint;
            //world = new World(ClientSize.Width, ClientSize.Height, backGround);
            
            KeyboardController controller = new KeyboardController(this);
            painter = new Painter(this);
            Engine engine = new Engine(controller, painter);
            var windowTimer = new Timer() { Interval = TimeInterval };
            windowTimer.Tick += (s, args) => engine.Play();
            windowTimer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (painter.Canvas != null)
            {
                e.Graphics.DrawImageUnscaled(painter.Canvas, Point.Empty);
            }
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

        public void UpdateScreen()
        {
            CheckKeyInput();

            //if (backBuffer != null)
            //{
            //    using (var g = Graphics.FromImage(backBuffer))
            //    {
            //        world.Draw(g);
            //    }
                
            //    Invalidate();
            //}
        }
    }
}
