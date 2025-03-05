using RobinMoses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace RobinMoses.Data
{
    public class WebSiteRepo : IWebSiteRepo
    {

        WebDbContext context;
        public WebSiteRepo(WebDbContext c)
        {
            context = c;
        }
        
        public async Task<int> AddAppUser(AppUser appUser)
        {
            await context.AddAsync(appUser);
            return await context.SaveChangesAsync();
        }

        public async Task<int>AddBlogPost(BlogPost blogPost)
        {
            await context.AddAsync(blogPost);
            return await context.SaveChangesAsync();
        }

        public async Task<int> AddMenuItem(MenuItem menuItem)
        {
            await context.AddAsync(menuItem);
            return await context.SaveChangesAsync();
        }

        public async Task<int> AddSpecialItem(SpecialItem specialItem)
        {
            await context.AddAsync(specialItem);
            return await context.SaveChangesAsync();
        }

        public List<BlogPost> GetBlogPosts()
        {
            return context.BlogPosts.ToList();
        }
        public async Task<BlogPost> GetBlogPostByIdAsync(int id)
        {
            var blogPost = await context.BlogPosts.FindAsync(id);
            return blogPost;
        }


        public Task<int> DeleteBlogId(int blogId)
        {
            var blogPost = context.BlogPosts.Find(blogId);
            context.BlogPosts.Remove(blogPost);
            return context.SaveChangesAsync();
        }

        public Task<int> UpdateBlogPost(BlogPost blogPost)
        {
            context.Update(blogPost);

            return context.SaveChangesAsync();
        }

        public List<MenuItem> GetMenuItem()
        {
            return context.MenuItems.ToList();
        }
        public async Task<MenuItem> GetMenuItemByIdAsync(int id)
        {
            var item = await context.MenuItems.FindAsync(id);
            return item ;
        }

        public Task<int> DeleteMenuItem(int MenuId)
        {
            var menuItem = context.MenuItems.Find(MenuId);
            context.MenuItems.Remove(menuItem);
            return context.SaveChangesAsync();
        }

        public Task<int> UpdateMenu(MenuItem menuItem)
        {
            context.Update(menuItem);

            return context.SaveChangesAsync();
        }


        public List<SpecialItem> GetSpecItem()
        {
            return context.SpecialItems.ToList();
        }

        public Task<int> DeleteSpecItem(int specItemId)
        {
            var specMenuItem = context.BlogPosts.Find(specItemId);
            context.BlogPosts.Remove(specMenuItem);
            return context.SaveChangesAsync();
        }

        public Task<int> UpdateSpecItem(SpecialItem specialItem)
        {
            context.Update(specialItem);

            return context.SaveChangesAsync();
        }
    }
}
