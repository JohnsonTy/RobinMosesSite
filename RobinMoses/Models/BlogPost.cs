using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RobinMoses.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        [NotMapped]
        public IFormFile? file { get; set; }
        public byte[]? Photo { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string? Tag { get; set; }
        public DateOnly? Date { get; set; }
    }
}
