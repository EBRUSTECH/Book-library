namespace BookLibrary.Models.Entities
{
    public class Rating : BaseEntity
    {
        public int Stars { get; set; }
        public string RaterId { get; set; } = "";
        public string BookId { get; set; } = "";

        // navigation property
        public AppUser Rater { get; set; }
        public Book Book { get; set; }
    }
}
