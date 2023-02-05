using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudRMS.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
