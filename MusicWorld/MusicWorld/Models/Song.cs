using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Song
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Artists { get; set; }
        public string Author { get; set; }
        public string UrlImage { get; set; }
    }
}
