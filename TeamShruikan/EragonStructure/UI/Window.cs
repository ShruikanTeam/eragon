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

        public void UpdateScreen()
        {
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
