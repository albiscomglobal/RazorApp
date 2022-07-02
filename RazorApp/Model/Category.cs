using System.ComponentModel.DataAnnotations;

namespace RazorApp.Model
{
    public class Category
    {
        [Key]
        public int MyProperty { get; set; }

        [Required]
        public int Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
