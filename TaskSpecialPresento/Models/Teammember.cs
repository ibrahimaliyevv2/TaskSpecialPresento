using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSpecialPresento.Models
{
    public class Teammember
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FullName { get; set; }
        [MaxLength(30)]
        public string Position { get; set; }
        [MaxLength(100)]
        public string TwitterUsername { get; set; }
        [MaxLength(100)]
        public string FacebookUsername { get; set; }
        [MaxLength(100)]
        public string InstagramUsername { get; set; }
        [MaxLength(100)]
        public string LinkedinUsername { get; set; }
        [MaxLength(100)]
        public string ImageName { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
