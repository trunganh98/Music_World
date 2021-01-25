using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Event
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Artists { get; set; }
        public string TicketPrice { get; set; }
        public string Place { get; set; }
        public string StartingDate { get; set; }
        public string UrlImage { get; set; }
    }
}
