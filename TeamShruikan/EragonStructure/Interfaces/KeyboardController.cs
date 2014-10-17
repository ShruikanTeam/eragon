namespace EragonStructure.Interfaces
{
    using System;
    using System.Windows.Forms;

    using EragonStructure.GameObjects;

    public class KeyboardController : IUserInput
    {
        public event EventHandler OnRightPressed;
        public event EventHandler OnLeftPressed;
        public event EventHandler OnUpPressed;
        public event EventHandler OnDownPressed;
        public event EventHandler OnSpacePressed;

        public KeyboardController(Form form)
        {
            form.KeyDown += FormKeyDown;
            form.MouseClick += MouseClick;
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
            if (this.OnSpacePressed != null)
            {
                var castArgs = new CharacterAttackEventArgs(e.X, e.Y);
                this.OnSpacePressed(this, castArgs);
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    if (this.OnUpPressed != null)
                    {
                        this.OnUpPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    if (this.OnDownPressed != null)
                    {
                        this.OnDownPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Left:
                case Keys.A:
                    if (this.OnLeftPressed != null)
                    {
                        this.OnLeftPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Space:
                    if (this.OnSpacePressed != null)
                    {
                        //this.OnSpacePressed(this, new CharacterAttackEventArgs(e.X, e.Y));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
