using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Dtos
{
    public class BookDetails
    {
        [Required(ErrorMessage = "Please enter the name field.")]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public string? Publication { get; set; }
    }
}
