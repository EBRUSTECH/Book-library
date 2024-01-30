namespace BookLibrary.Models.ViewModels
{
    public class HomeViewModel
    {
        public Dictionary<string, List<string>> Tabs { get; set; } = new Dictionary<string, List<string>>();
        public ShowCase NewRelease { get; set; } = new ShowCase();

        public ShowCase MostPopular { get; set; } = new ShowCase();
    }

    public class ShowCase
    {
        public IList<BookSummarizedViewModel> BookList { get; set; } = new List<BookSummarizedViewModel>();
        public int Books { get; set; }
        public int CDs { get; set; }
    }
}
