using System.ComponentModel.DataAnnotations;

namespace Reward.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
    }
}
