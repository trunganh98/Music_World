using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Event
    {
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ArtistsID { get; set; }

        public string TicketPrice { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        public string StartingDate { get; set; }
        [Display(Name = "Image")]
        public string UrlImage { get; set; }
    }
}
