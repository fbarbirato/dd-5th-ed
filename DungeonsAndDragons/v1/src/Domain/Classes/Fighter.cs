using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain.Classes
{
    public class Fighter : Class
    {
        public override Dice HitDie { get { return Dice.D10; } }
    }
}
