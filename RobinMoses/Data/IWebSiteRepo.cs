using RobinMoses.Models;
using Microsoft.AspNetCore.Mvc;

namespace RobinMoses.Data
{
    public interface IWebSiteRepo
    {
        
       
        public Task<int> AddAppUser(AppUser appUser);

        public Task<int> AddBlogPost(BlogPost blogPost);
        public List<BlogPost> GetBlogPosts();
        public Task<int> DeleteBlogId(int blogId);
        public Task<int> UpdateBlogPost(BlogPost blogPost);
        public Task<int> AddMenuItem(MenuItem menuItem);
        public List<MenuItem> GetMenuItem();
        public Task<MenuItem> GetMenuItemByIdAsync(int id);

        public Task<BlogPost> GetBlogPostByIdAsync(int id);
        public Task<int> DeleteMenuItem(int MenuId);
        public Task<int> UpdateMenu(MenuItem menuItem);
        public Task<int> AddSpecialItem(SpecialItem specialItem);
        public List<SpecialItem> GetSpecItem();
        public Task<int> DeleteSpecItem (int specItemId);
        public Task<int> UpdateSpecItem(SpecialItem specialItem);
    }
}
