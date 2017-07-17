using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain.Classes
{
    public class Wizard : Class
    {
        public override Dice HitDie => Dice.D6;
    }
}
