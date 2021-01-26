using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Artists
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Image")]
        public string UrlImage { get; set; }
    }
}
