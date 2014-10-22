namespace EragonStructure
{
    using EragonStructure.Structs;

    public class Picture
    {
        public Picture(System.Drawing.Bitmap img)
        {
            Image = img;
            this.Size = new EragonStructure.Structs.Size(Image.Width, Image.Height);
        }

        public Size Size { get; set; }

        public System.Drawing.Bitmap Image { get; set; }

        public int SpriteColumns { get; set; }

    }
}
