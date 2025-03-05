using RobinMoses.Data;
using RobinMoses.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RobinMoses.Controllers
{
    public class BlogController : Controller
    {
        IWebSiteRepo repository;
        WebDbContext context;
        public BlogController(IWebSiteRepo m)
        {
            repository = m;
        }
        public IActionResult Index(string title, string text, string tag)
        {
                var blogPosts = from b in repository.GetBlogPosts()
                                select b;

                //var datedPosts = repository.GetBlogPosts()
                    //.Where(post => post.Date >= date && post.Date <= date)
                    //.ToList();
                //DateOnly nonNullableDate = date ?? DateOnly.FromDateTime(DateTime.Today);

            if (!String.IsNullOrEmpty(title))
                {
                    blogPosts = blogPosts.Where(b => b.Title.Contains(title));
                }

            if (!String.IsNullOrEmpty(text))
            {
                blogPosts = blogPosts.Where(b => b.Text.Contains(text));
            }

            //if (date != null)
                // Convert DateOnly to DateTime for da filterin
                //var fromDate = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, 0, 0, 0);
                //var toDate = fromDate.AddDays(1); //.ToList<BlogPost>();
                //blogPosts = blogPosts.Where(b => b.Date >= fromDate && b.Date < toDate); 

            if (!String.IsNullOrEmpty(tag))
            {
                blogPosts = blogPosts.Where(b => b.Tag.Contains(tag));
            }
            
            return View(blogPosts.ToList());
        }

        [Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(BlogPost model)
        {
            if (ModelState.IsValid)
            {
                if (model.file != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        await model.file.CopyToAsync(stream);
                        model.Photo = stream.ToArray();
                    }
                }
                model.Date = DateOnly.FromDateTime(DateTime.Now);
                await repository.AddBlogPost(model);

                return RedirectToAction("Index");
            }
            else 
            {
                return View(); 
            }

        }

        public async Task<IActionResult> BlogPage(int blogId)
        {
            var blogPost = await repository.GetBlogPostByIdAsync(blogId);
            return View(blogPost);
        }


        [Authorize]
        public async Task<IActionResult> Delete(int blogId)
        {
            await repository.DeleteBlogId(blogId);
            return RedirectToAction("Index");
        }


        [Authorize]
        public async Task<IActionResult> EditBlogPost(int BlogId)
        {
            var blogpost = await repository.GetBlogPostByIdAsync(BlogId);
            
            return View(blogpost);
        }



        [HttpPost]
        public async Task<IActionResult> EditBlogPost(BlogPost blogPost)
        {
            var oldblogpost = await repository.GetBlogPostByIdAsync(blogPost.PostId);
            oldblogpost.Title = blogPost.Title;
            oldblogpost.Text = blogPost.Text;
            oldblogpost.Tag = blogPost.Tag;
            await repository.UpdateBlogPost(oldblogpost);

            return RedirectToAction("Index");
        }



    }
}
