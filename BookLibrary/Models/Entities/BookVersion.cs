using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models.Entities
{
    public class BookVersion
    {
        [Key]
        public int BookVersionId { get; set; }
        public string Version { get; set; }
        public int CopiesInLibrary { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}
