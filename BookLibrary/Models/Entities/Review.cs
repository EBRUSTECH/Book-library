namespace BookLibrary.Models.Entities
{
    public class Review : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Text { get; set; } = "";
        public string ReviewerId { get; set; } = "";
        public string BookId { get; set; } = "";

        // navigation property
        public AppUser Reviewer { get; set; }
        public Book Book { get; set; }

    }
}
