using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Keep less than 101")]
        public int order { get; set; }
        public DateTime createdDateTime { get; set; } = DateTime.Now;
    }
}
