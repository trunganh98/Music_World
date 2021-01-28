using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Song
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Artists { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        [Display(Name = "Image")]
        public string UrlImage { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
