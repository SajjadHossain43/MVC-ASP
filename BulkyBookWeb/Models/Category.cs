using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int order { get; set; }
        public DateTime createdDateTime { get; set; } = DateTime.Now;
    }
}
