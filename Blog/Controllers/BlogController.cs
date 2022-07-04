using Microsoft.AspNetCore.Mvc;
using Blog.Models;
using System.Linq;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {

        static List<BlogEntry> Posts = new List<BlogEntry>();

        public IActionResult Index()
        {
            return View("Index", Posts);
        }
        public IActionResult CreatorPage(Guid id)
        {
            if(id != Guid.Empty)
            {
                BlogEntry existingEntry = Posts.FirstOrDefault(x => x.Id == id);

                return View(model: existingEntry);
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreatorPage(string content)
        {
            BlogEntry entry=new BlogEntry();
            entry.Content = content;
            entry.Id = Guid.NewGuid();

            Posts.Add(entry);
            return RedirectToAction("Index");
        }
    }
}
