using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Album
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
      
        
        [Display(Name = "Image")]
        public string UrlImage { get; set; }

        public Song Songs { get; set; }
        public Artists Artists { get; set; }
    }
}
