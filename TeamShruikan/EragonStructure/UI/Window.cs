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
using EragonStructure.Structs;
using Point = System.Drawing.Point;

namespace EragonStructure.UI
{
    public partial class Window : Form
    {
        public const int TimeInterval = 20;
        private Bitmap backBuffer;
        private Picture backGround;
        private Picture heroPicture;
        private World world;
        private Fighter hero;

        public Window()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);

            Load += Form1_CreateBackBuffer;
            Paint += Form1_Paint;

            LoadImages();
            world = new World(ClientSize.Width, ClientSize.Height, backGround);
            hero = new Fighter(new Structs.Point(100, 350),
                new EragonStructure.Structs.Size(heroPicture.Image.Width, heroPicture.Image.Height),
                heroPicture,
                "bai ivan",
                90, 120, 10, 100, 200, 10, 1, 10);
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
                backGround = new Picture(Image.FromFile(resPath + "Eragon_Saphira.png"));
                heroPicture = new Picture(Image.FromFile(resPath + "hero.png"));
            }
            catch (IOException)
            {
                Console.WriteLine("cannot read from file!");
                return;
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

        private void UpdateScreen()
        {
            if (backBuffer != null)
            {
                using (var g = Graphics.FromImage(backBuffer))
                {
                    //g.Clear(Color.White);
                    //g.FillRectangle(Brushes.Black, 100, 100, 300, 200 );
                    world.Draw(g);
                }

                Invalidate();
            }
        }
    }
}
