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

        public async Task<int> AddMenuItem(MenuItem menuItem)
        {
            menuItem.ItemId = menuItems.Count + 1;
            menuItems.Add(menuItem);
            return menuItem.ItemId;
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

        public Task<int> DeleteMenuItem(int MenuId)
        {
            var MenuItem = menuItems[MenuId - 1];
            menuItems.RemoveAt(MenuId - 1);
            MenuItem.ItemId = 0;
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

        public List<MenuItem> GetMenuItem()
        {
            throw new NotImplementedException();
        }

        public Task<MenuItem> GetMenuItemByIdAsync(int id)
        {
            return Task.FromResult(menuItems[id - 1]);
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
