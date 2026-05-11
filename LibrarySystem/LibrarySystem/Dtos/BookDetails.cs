using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Dtos
{
    public class BookDetails
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publication { get; set; }
    }
}
