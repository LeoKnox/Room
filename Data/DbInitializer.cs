using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRoom.Data;
using MvcRoom.Models;

namespace MvcRoom.Data
{
    public class DbInitializer
    {
        public static void Initialize(DungeonContext context)
        {
            context.Database.EnsureCreated();

            if (context.Room.Any())
            {
                return;
            }

            var rooms = new Room[]
            {
                new Room{Name="Entry",Style="Wood",Length=5,Width=5},
                new Room{Name="Hall",Style="Stone",Length=6,Width=4 }
            };
            foreach (Room r in rooms)
            {
                context.Room.Add(r);
            }
            context.SaveChanges();

            var doors = new Door[]
            {
                new Door{DoorID=1,Design="Iron",Location=3},
                new Door{DoorID=4,Design="Secret",Location=4}
            };
            foreach (Door d in doors)
            {
                context.Door.Add(d);
            }
            context.SaveChanges();

            var features = new Feature[]
            {
                new Feature{RoomID=1,DoorID=1,Inside=Inside.Item},
                new Feature{RoomID=4, DoorID=2,Inside=Inside.Monster}
            };
            foreach (Feature f in features)
            {
                context.Features.Add(f);
            }
            context.SaveChanges();
        }
    }
}
