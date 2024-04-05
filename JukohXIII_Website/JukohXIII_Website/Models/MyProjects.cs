using System.ComponentModel.DataAnnotations;

namespace JukohXIII_Website.Models
{
    public class MyProjects
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ImagePath { get; set; }
       
    }
}
