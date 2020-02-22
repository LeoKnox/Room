﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRoom.Models;

namespace MvcRoom.Data
{
    public class DungeonContext : DbContext
    {
        public DungeonContext (DbContextOptions<DungeonContext> options)
            : base(options)
        {
        }

        public DbSet<Room> Room { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Door> Door { get; set; }
    }
}
