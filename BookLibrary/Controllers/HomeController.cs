using BookLibrary.Models;
using BookLibrary.Models.ViewModels;
using BookLibrary.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;
        private readonly ITabService _tabService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService, ITabService tabServic)
        {
            _logger = logger;
            _bookService = bookService;
            _tabService = tabServic;
        }

        //public ActionResult Index()
        //{
        //    var homeVewModel = new HomeViewModel();
        //    return View(homeVewModel);
        //}

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var homeVewModel = new HomeViewModel();
            // get new released books
            var newReleasedBooks = await _bookService.GetNewReleasedBooks();
            //var tabs = await _tabService.GetAll();


            foreach (var item in newReleasedBooks)
            {
                homeVewModel.NewRelease.BookList.Add(new BookSummarizedViewModel
                {
                    Id = item.Id,
                    PhotoUrl = item.PhotoUrl,
                    Stars = item.Ratings.Where(x => x.BookId == x.Id).Count(),
                    AuthorName = item.Author,
                    AvailabilityStatus = item.BookVersions.Count() > 0
                });
            }

            return View(homeVewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

/*
  homeVewModel.NewRelease = new ShowCase
            {
                Books = 20,
                CDs = 25,
                BookList = new List<BookSummarizedViewModel>
                {
                    new BookSummarizedViewModel
                    {
                        Id = "1",
                        AuthorName = "Sarah Penner",
                        Title = "The Lost Apothecary",
                        Genre = "Fiction",
                        PhotoUrl = "",
                        Stars = 5,
                        AvailabilityStatus = true,
                    },
                    new BookSummarizedViewModel
                    {
                        Id = "2",
                        AuthorName = "Subhara Moitra",
                        Title = "Fitness Habits",
                        Genre = "Non-Fiction",
                        PhotoUrl = "",
                        Stars = 4,
                        AvailabilityStatus = true,
                    },
                    new BookSummarizedViewModel
                    {
                        Id = "3",
                        AuthorName = "Janet Skes CHARLES",
                        Title = "Parts Library",
                        Genre = "Fiction",
                        PhotoUrl = "",
                        Stars = 4,
                        AvailabilityStatus = true,
                    }
                }
            };
            homeVewModel.Tabs = new Dictionary<string, List<string>>
            {
                { "Fiction", new List<string>{"Drama","Horror", "Mystery", "Sci-fi"} },
                { "Non-Fiction", new List<string>{"Art","Biography", "Sports", "Travel"} },
                { "CD Genres", new List<string>{"Blues","Classical", "Folk", "Reggae", "Hip-Hop", "Rap", "Rock"} }
            };

 */