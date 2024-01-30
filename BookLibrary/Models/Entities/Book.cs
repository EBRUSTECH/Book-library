namespace BookLibrary.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Description { get; set; } = "";
        public string Language { get; set; } = "";
        public string ISBN { get; set; } = "";
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; } = "";
        public string PhotoUrl { get; set; } = "";
        public string PublicId { get; set; } = "";
        public string AddedBy { get; set; } = "";
        public DateTime PublishedDate { get; set; }
        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }

        // Navigation prop
        public ICollection<BookVersion> BookVersions { get; set; } = new List<BookVersion>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
