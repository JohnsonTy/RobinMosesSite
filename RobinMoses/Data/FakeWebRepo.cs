using RobinMoses.Models;
using Microsoft.AspNetCore.Mvc;

namespace RobinMoses.Data
{
    public class FakeWebRepo : IWebSiteRepo
    {
        List<BlogPost> blogPosts = new List<BlogPost>();
        List<MenuItem> menuItems = new List<MenuItem>();

        public Task<int> AddAppUser(AppUser appUser)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddBlogPost(BlogPost blogPost)
        {
            blogPost.PostId = blogPosts.Count + 1;
            blogPosts.Add(blogPost);
            return blogPost.PostId;
        }

        public Task<int> AddSpecialItem(SpecialItem specialItem)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBlogId(int blogId)
        {

            var blogPost = blogPosts[blogId - 1];
            blogPosts.RemoveAt(blogId - 1);
            blogPost.PostId = 0;
            return Task.FromResult(1);
        }

        public int DeletePhotos(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteSpecItem(int specItemId)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> GetBlogPostByIdAsync(int id)
        {
            return Task.FromResult(blogPosts[id - 1]);
        }

        public List<BlogPost> GetBlogPosts()
        {
            throw new NotImplementedException();
        }

        public List<SpecialItem> GetSpecItem()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateBlogPost(BlogPost blogPost)
        {
            blogPost.Title = "EditTest";
            blogPosts[blogPost.PostId - 1] = blogPost;

            return Task.FromResult(1);
        }

        public Task<int> UpdateMenu(MenuItem menuItem)
        {
            menuItem.Name = "EditTest";
            menuItems[menuItem.ItemId - 1] = menuItem;

            return Task.FromResult(1);
        }

        public Task<int> UpdateSpecItem(SpecialItem specialItem)
        {
            throw new NotImplementedException();
        }
    }
}
