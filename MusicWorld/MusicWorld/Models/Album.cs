﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Image")]
        public string UrlImage { get; set; }
        public string ReleaseDate { get; set; }

        public ICollection<Song> Songs { get; set; }
        public ICollection<Artists> Artists { get; set; }
    }
}
