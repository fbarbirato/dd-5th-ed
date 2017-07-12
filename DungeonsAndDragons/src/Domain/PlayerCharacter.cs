using System;

namespace DungeonsAndDragons.Domain
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Race Race { get; set; }
        public Class Class { get; set; }
    }
}
