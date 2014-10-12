using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EragonStructure.GameObjects
{
    public class CharacterAttackEventArgs : EventArgs
    {
        public CharacterAttackEventArgs(int x, int y)
        {
            this.AttackX = x;
            this.AttackY = y;
        }

        public int AttackX { get; set; }
        public int AttackY { get; set; }
    }
}
