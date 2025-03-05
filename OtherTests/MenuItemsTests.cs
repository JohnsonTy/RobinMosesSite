using RobinMoses.Controllers;
using RobinMoses.Data;
using RobinMoses.Models;

namespace RobinMosesUnitTests1
{
    public class MenuItemsTests
    {

        [Fact]
        public void MenuPostTest()
        {
            var repo = new FakeWebRepo();
            var controller = new MenuController(repo);
            var model = new MenuItem()
            {
                Name = "Test",
                Price = 10,
                Category = "Test",
                Description = "Test",
            };
            controller.Add(model).Wait();

            Assert.True( model.ItemId > 0);
        }
        [Fact]
        public void DeleteMenuPostTest()
        {
            var repo = new FakeWebRepo();
            var controller = new MenuController(repo);
            var model = new MenuItem()
            {
                Name = "Test",
                Price = 10,
                Category = "Test",
                Description = "Test",
            };
            controller.Add(model).Wait();
            controller.DeleteMenuItem(model.ItemId).Wait();
            Assert.False(model.ItemId > 0);
        }
        [Fact]
        public void EditMenuPostTest()
        {
            var repo = new FakeWebRepo();
            var controller = new MenuController(repo);
            var model = new MenuItem()
            {
                Name = "Test",
                Price = 10,
                Category = "Test",
                Description = "Test",
            };
            controller.Add(model).Wait();
            var newmodel = new MenuItem()
            {
                ItemId = model.ItemId,
                Name = "Test",
                Price = 10,
                Category = "Test",
                Description = "Test",
            };
            //make sure they are equal to each other
            Assert.True(model.Name == newmodel.Name);

            controller.EditMenuItem(newmodel).Wait();

            //make sure it was edited correrectlly
            Assert.False(model.Name == newmodel.Name);
        }



    }
}