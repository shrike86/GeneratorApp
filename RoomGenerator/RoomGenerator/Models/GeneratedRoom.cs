using System;
using System.Collections.Generic;
using System.Text;

namespace RoomGenerator.Models
{
    public class GeneratedRoom
    {
        public Generator Place { get; set; }
        public Generator BasicRoomStocking { get; set; }
        public Generator RoomAtmosphere { get; set; }
        public Generator RoomOrnamentations { get; set; }
        public Generator NeutralInhabitant { get; set; }
        public Generator DangerousInhabitant { get; set; }
        public Generator InhabitantReaction { get; set; }
        public Generator Device { get; set; }
        public Generator Trap { get; set; }
        public Generator Treasure { get; set; }
    }
}
