namespace EragonStructure.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class World : IDrawable
    {
        private Bitmap canvas;
        private IList<GameObject> objects;

        public World(int width, int height, Picture background)
        {
                canvas = new Bitmap(background.Image, width, height);
        }

        internal void AddObject(GameObject gameObject)
        {
            if (objects == null)
            {
                objects = new List<GameObject>();
            }

            objects.Add(gameObject);
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(canvas, 0f, 0f);

            if (objects != null && objects.Count > 0)
            {
                foreach (var gameObject in objects)
                {
                    gameObject.Draw(g);
                }
            }
        }
    }
}
