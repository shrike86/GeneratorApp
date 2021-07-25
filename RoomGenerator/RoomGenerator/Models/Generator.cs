using System;
using System.Collections.Generic;
using System.Text;

namespace RoomGenerator.Models
{
    public abstract class Generator
    {
        public string Description { get; set; }
        public string GeneratedValue { get; set; }
        public string GeneratedValue2 { get; set; }
        public string GeneratedValue3 { get; set; }
        public GeneratorType Type { get; set; }
    }

    public enum GeneratorType
    {
        Place,
        BasicRoomStocking,
        RoomAtmosphere,
        RoomOrnamentation,
        NeutralRoomInhabitant,
        DangerousRoomInhabitant,
        Device,
        Trap,
        Treasure
    }
}
