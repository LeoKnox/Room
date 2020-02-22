using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRoom.Models
{
    public enum Inside
    {
        Item, Monster, Treasure
    }
    public class Feature
    {
        public int FeatureID { get; set; }
        public int DoorID { get; set; }
        public int RoomID { get; set; }
        public Inside? Inside { get; set; }

        public Door Door { get; set; }
        public Room Room { get; set; }
    }
}
