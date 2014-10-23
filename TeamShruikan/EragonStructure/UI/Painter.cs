using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EragonStructure.Interfaces;
using EragonStructure.GameObjects;
using System.IO;

namespace EragonStructure.UI
{
    public class Painter : IPainter
    {
        private Form window;
        private Bitmap backBuffer;
        private Picture backGround;
        private Picture fighterPicture;
        private Picture magePicture;
        private Picture creepPicture;
        private Picture skeletonPicture;
        private Picture bossPicture;
        private Picture bowPicture;

        public Painter(Form form)
        {
            window = form;
            Painter.GoFullscreen(window, true);
            LoadResources();
            CreateBackBuffer();
        }

        public Form Window
        {
            get { return window; }
        }

        public Image Canvas
        {
            get { return backBuffer; }
        }

        public Picture FighterPicture
        {
            get { return fighterPicture; }
        }

        public Picture MagePicture
        {
            get { return magePicture; }
        }

        public Picture CreepPicture
        {
            get { return creepPicture; }
            set { creepPicture = value; }
        }

        public Picture SkeletonPicture
        {
            get { return skeletonPicture; }
            set { skeletonPicture = value; }
        }

        public Picture BossPicture
        {
            get { return bossPicture; }
        }

        public Picture BowPicture
        {
            get { return bowPicture; }
            set { bowPicture = value; }
        }

        public void LoadResources()
        {
            string resPath = Directory.GetCurrentDirectory() + @"..\..\..\Resources\";
            try
            {
                backGround = new Picture(new Bitmap(Image.FromFile(resPath + @"Castles\castlemap01.jpg"), new System.Drawing.Size(window.Width, window.Height)));
                fighterPicture = new Picture(new Bitmap(Image.FromFile(resPath + @"NiceGuys\archer2.png"), new System.Drawing.Size(80, 100)));
                magePicture = new Picture(new Bitmap(Image.FromFile(resPath + @"NiceGuys\iceWitch_welcome.png"), new System.Drawing.Size(120, 100)));
                creepPicture = new Picture(new Bitmap(Image.FromFile(resPath + @"BadGuys_Monsters\BossCyclop.png"), new System.Drawing.Size(90, 100)));
                skeletonPicture = new Picture(new Bitmap(Image.FromFile(resPath + @"BadGuys_Monsters\SkeletonArcher.png"), new System.Drawing.Size(90, 100)));
                bossPicture = new Picture(new Bitmap(Image.FromFile(resPath + @"BadGuys\BossIceMonster01.png"), new System.Drawing.Size(160, 160)));
                bowPicture = new Picture(new Bitmap(Image.FromFile(resPath + @"NiceGuys\FFXI_Archery_2.png"), new System.Drawing.Size(80, 80)));
            }
            catch (IOException)
            {
                Console.WriteLine("cannot read from file!");
            }
        }

        public void Update()
        {
            if (backBuffer != null)
            {
                //e.DrawImageUnscaled(backBuffer, Point.Empty);
                Graphics.FromImage(backBuffer).DrawImage(backGround.Image, 0f, 0f);
                //backBuffer = backGround.Image;
            }
        }

        private void CreateBackBuffer()
        {
            if (backBuffer != null)
                backBuffer.Dispose();

            backBuffer = new Bitmap(window.Width, window.Height);
            //backBuffer = backGround.Image;
            
        }

        public static void GoFullscreen(Form form, bool fullscreen)
        {
            if (fullscreen)
            {
                form.WindowState = FormWindowState.Normal;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        public void AddObject(IDrawable renderableObject)
        {
            throw new NotImplementedException();
        }

        public void RemoveObject(IDrawable renderableObject)
        {
            throw new NotImplementedException();
        }

        public void RedrawObject(IDrawable renderableObject)
        {
            throw new NotImplementedException();
        }
    }
}
