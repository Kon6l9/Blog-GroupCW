using Bloggie.Web.Models;
using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModels;
using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing.Printing;

namespace Bloggie.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogPostRepository blogPostRepository;
        private readonly IBlogPostLikeRepository blogPostLikeRepository;


        public HomeController(ILogger<HomeController> logger,
            IBlogPostRepository blogPostRepository,
            IBlogPostLikeRepository blogPostLikeRepository
            )
        {
            _logger = logger;
            this.blogPostRepository = blogPostRepository;
            this.blogPostLikeRepository = blogPostLikeRepository;
        }

        public async Task<IActionResult> Index(int page = 1, string sort = "recency")
        {
            const int pageSize = 5;
            IEnumerable<BlogPost> blogPosts;

            switch (sort.ToLower())
            {
                case "random":
                    blogPosts = await blogPostRepository.GetAllAsync();
                    blogPosts = blogPosts.OrderBy(x => Guid.NewGuid()).ToList();
                    break;
                case "popularity":
                    blogPosts = await blogPostLikeRepository.GetAllSortedByPopularityAsync();
                    break;
                case "recency":
                default:
                    blogPosts = await blogPostRepository.GetAllSortedByDateAsync();
                    break;
            }

            var totalPosts = blogPosts.Count();
            var paginatedPosts = blogPosts.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var model = new HomeViewModel
            {
                BlogPosts = paginatedPosts,
                CurrentPage = page,
                TotalPosts = totalPosts,
                PostsPerPage = pageSize,
                SortOrder = sort
            };


            return View(model);
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