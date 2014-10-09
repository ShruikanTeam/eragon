using EragonStructure.GameObjects;
using System;
using System.Windows.Forms;

namespace EragonStructure.Interfaces
{
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
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (this.OnUpPressed != null)
                    {
                        this.OnUpPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Right:
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Down:
                    if (this.OnDownPressed != null)
                    {
                        this.OnDownPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Left:
                    if (this.OnLeftPressed != null)
                    {
                        this.OnLeftPressed(this, new EventArgs());
                    }
                    break;
                case Keys.Space:
                    if (this.OnSpacePressed != null)
                    {
                        this.OnSpacePressed(this, new CharacterAttackEventArgs(e.X, e.Y));
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
