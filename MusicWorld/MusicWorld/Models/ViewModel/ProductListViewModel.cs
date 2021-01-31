﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models.ViewModel
{
    public class ProductListViewModel
    {
        public IEnumerable<Song> Songs { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Event> Events{ get; set; }
        public IEnumerable<Artists> Artists { get; set; }

        public string CurrentCategory { get; set; }
    }
}
