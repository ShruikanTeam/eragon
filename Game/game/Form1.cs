namespace game
{
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

    public partial class Form1 : Form
    {
        public Image hero;
        public Image Background;
        public Bitmap anim = new Bitmap(64, 64);
        public int step = 0;
        public int X = 250;
        public int Y = 350;

        public Form1()
        {
            InitializeComponent();
            
            new Settings();
            loadImages();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }



        public void loadImages()
        {
            string ResPath = Directory.GetCurrentDirectory() + @"..\..\..\Resources\";
            try
            {
                hero = Image.FromFile(ResPath + "Run.png");
                Background = Image.FromFile(ResPath + "Eragon_Saphira.png");
            }
            catch (IOException)
            {
                Console.WriteLine("cannot read from file!");
                return;
            }
        }

        private void StartGame()
        {
            //Set settings to default
            new Settings();
            Settings.GameOver = false;
            Settings.direction = Direction.Left;
            //Create new player object

        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            step++;
            if (step > 9) step = 0;
            //Form1.ActiveForm.Text = step.ToString();
            Form1.ActiveForm.Text = Settings.direction.ToString();

            //Check for Game Over
            if (Settings.GameOver)
            {
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pictureBox1.Invalidate();

        }

        private void MovePlayer()
        {
            //Move head
            switch (Settings.direction)
            {
                case Direction.Right:
                    X += Settings.moveSpeed;
                    break;
                case Direction.Left:
                    X -= Settings.moveSpeed;
                    break;
                case Direction.Up:
                    Y -= Settings.moveSpeed;
                    break;
                case Direction.Down:
                    Y += Settings.moveSpeed;
                    break;
            }


            //Get maximum X and Y Pos
            int maxXPos = pictureBox1.Size.Width;
            int maxYPos = pictureBox1.Size.Height;

            //Detect collission with game borders.
            if (X < 0 )
            {
                Settings.direction = Direction.Right;
            }
            
            if (Y < 0)
            {
                Settings.direction = Direction.Down;
            }

            if (X > pictureBox1.Width)
            {
                Settings.direction = Direction.Left;
            }

            if (Y > pictureBox1.Height)
            {
                Settings.direction = Direction.Up;
            }
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.DrawImage(Background, new RectangleF(0, 0, 640, 450), new RectangleF(0, 0, 640, 450), GraphicsUnit.Pixel);
            canvas.DrawImage(hero,
                new RectangleF(X - anim.Width / 2, Y - anim.Height / 2, anim.Width, anim.Height),
                new RectangleF(anim.Width * step, 0, 64, 64),
                GraphicsUnit.Pixel);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}
