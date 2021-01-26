﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public interface IMusicReposity
    {
        IQueryable<Song> Songs { get; }
        IQueryable<Artists> Artists { get; }
        IQueryable<Album> Albums { get; }
        IQueryable<Event> Events { get; }
        IQueryable<User> Users { get; }
    }
}
