using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Data
{
    public class BaseEntity
    {
        [Key]
        public string    Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string IP { get; set; }
    }
}
