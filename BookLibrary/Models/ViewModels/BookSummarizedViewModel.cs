namespace BookLibrary.Models.ViewModels
{
    public class BookSummarizedViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string PhotoUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int Stars { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public bool AvailabilityStatus { get; set; }
    }
}
