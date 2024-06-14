using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BlogPost> BlogPosts { get; set; }


                // Pagination properties
        public int CurrentPage { get; set; }
        public int TotalPosts { get; set; }
        public int PostsPerPage { get; set; } = 5;

        public string SortOrder { get; set; }
    }
}
