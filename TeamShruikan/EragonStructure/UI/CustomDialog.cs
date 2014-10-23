using System.Windows.Forms;

namespace EragonStructure.UI
{
    public static class CustomDialog
    {
        public static int ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 200;
            prompt.Text = caption;
            Label textLabel = new Label() {Left = 50, Top = 20, Text = text};
            Button attack = new Button() {Text = "Attack + 5", Left = 150, Width = 100, Top = 70};
            Button defence = new Button() { Text = "Defence + 5", Left = 350, Width = 100, Top = 70 };
            int choise = 0;
            attack.Click += (sender, e) =>
            {
                choise = 1;
                prompt.Close(); 
            };
            defence.Click += (sender, e) =>
            {
                choise = 2;
                prompt.Close();
            };
            prompt.Controls.Add(attack);
            prompt.Controls.Add(defence);
            prompt.Controls.Add(textLabel);
            prompt.ShowDialog();
            return choise;
        }
    }
}