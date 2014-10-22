using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EragonStructure.GameObjects;

namespace EragonStructure.Interfaces
{
    public interface IPainter
    {
        void AddObject(IDrawable renderableObject);

        void RemoveObject(IDrawable renderableObject);

        void RedrawObject(IDrawable renderableObject);
    }
}
