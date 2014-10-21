namespace EragonStructure
{
    using EragonStructure.Structs;

    public class Picture
    {
        public Picture(System.Drawing.Image img)
        {
            Image = img;
        }

        public Size Size { get; set; }

        public System.Drawing.Image Image { get; set; }

        public int SpriteColumns { get; set; }

    }
}
