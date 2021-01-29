﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string TicketPrice { get; set; }
        public string Place { get; set; }
        public string StartingDate { get; set; }
        [Display(Name = "Image")]
        public string UrlImage { get; set; }

        public ICollection<Artists> Artists { get; set; }
    }
}
