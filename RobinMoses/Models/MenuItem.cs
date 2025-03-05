using System.ComponentModel.DataAnnotations;

namespace RobinMoses.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
