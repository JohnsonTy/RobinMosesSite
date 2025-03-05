using RobinMoses.Controllers;
using RobinMoses.Data;
using RobinMoses.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinMosesUnitTests1
{
    public class BlogPostTests
    {
      
        [Fact]
        public void BlogPostTest()
        {
            var repo = new FakeWebRepo();
            var controller = new BlogController(repo);
            var model = new BlogPost()
            {
                Title = "Test",
                Tag = "Test",
                Text = "Test",

            };
            controller.Add(model).Wait();

            Assert.True(model.PostId > 0);
        }
        [Fact]
        public void deleteBlogPostTest()
        {
            var repo = new FakeWebRepo();
            var controller = new BlogController(repo);
            var model = new BlogPost()
            {
                Title = "Test",
                Tag = "Test",
                Text = "Test",

            };
            controller.Add(model).Wait();
            controller.Delete(model.PostId).Wait();
            Assert.False(model.PostId > 0);
        }
        [Fact]
        public void EditBlogPostTest()
        {
            var repo = new FakeWebRepo();
            var controller = new BlogController(repo);
            var model = new BlogPost()
            {
                Title = "Test",
                Tag = "Test",
                Text = "Test",

            };
            controller.Add(model).Wait();
            var newmodel = new BlogPost()
            {
                PostId = model.PostId,
                Title = "Test",
                Tag = "Test",
                Text = "Test",

            };
            //make sure they are equal to each other
            Assert.True(model.Title == newmodel.Title);

            controller.EditBlogPost(newmodel).Wait();

            //make sure it was edited correrectlly
            Assert.False(model.Title == newmodel.Title);
        }
    }
}
