
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CW2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("User Name")]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        [DisplayName("User Password")]
        public string Password { get; set; }
    }
}
