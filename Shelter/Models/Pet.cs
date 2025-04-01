using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shelter.Models
{
    public class Pet
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Range(0, 30)]
        public int Age { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Range(0, 120)]
        public int Weight { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [RegularExpression(@"^https://.*\.(jpg|jpeg|png|gif|bmp|tiff)$", ErrorMessage = "You can only upload image files!")]
        public string PhotoURL { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [ForeignKey("ReferencedCategory")]
        public int CategoryId { get; set; }

        public virtual Category? ReferencedCategory { get; set; }
    }
}
