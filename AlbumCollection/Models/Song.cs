using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

        [Display(Name = "Song Name:")]
        public string Name { get; set; }

        [Display(Name = "Run Time:")]
        public string RunTime { get; set; }
    }
}
