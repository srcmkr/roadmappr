using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using roadmappr.Controllers;
using roadmappr.Data;
using roadmappr.Models;
using roadmappr.Models.ViewModels;

namespace roadmapprTests
{
    [TestClass]
    public class TrelloDataModelTest
    {
        [TestMethod]
        public void Construct()
        {
            var testModel = new TrelloDataModel("wiOPDS9X");
            Assert.AreEqual(false, testModel.IsLoaded);
        }

        [TestMethod]
        public void DownloadAsync()
        {
            var testModel = new TrelloDataModel("wiOPDS9X");
            var result = testModel.DownloadAsync().Result;
            Assert.IsInstanceOfType(result, typeof(Trello));
        }

        [TestMethod]
        public void LoadAsync()
        {
            var testModel = new TrelloDataModel("wiOPDS9X");
            var result = testModel.LoadAsync().Result;
            Assert.IsInstanceOfType(result, typeof(Trello));
        }

        [TestMethod]
        public void LoadExistingFromDatabase()
        {
            var testModel = new TrelloDataModel("wiOPDS9X");
            var result = testModel.LoadFromDatabase();
            Assert.IsInstanceOfType(result, typeof(Trello));
        }

        [TestMethod]
        public void LoadNonExistingFromDatabase()
        {
            var testModel = new TrelloDataModel("idontexist");
            var result = testModel.LoadFromDatabase();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void AddOrUpdate()
        {
            var testModel = new TrelloDataModel("wiOPDS9X");

            var trello = new Trello
            {
                Name = "Test"
            };

            var result = testModel.AddOrUpdate(trello);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BoardControllerTest()
        {
            var controller = new BoardController();
            var result = controller.Index("wiOPDS9X").Result;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BoardControllerInvalidTest()
        {
            var controller = new BoardController();
            var result = controller.Index("idontexist").Result;
            Assert.IsInstanceOfType(result, typeof(IActionResult));
        }

        [TestMethod]
        public void HomeIndexTest()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BoardViewModelTest()
        {
            var model = new BoardViewModel
            {
                Source = "test",
                TrelloBoard = new Trello()
            };
            Assert.IsNotNull(model.Source);
            Assert.IsNotNull(model.TrelloBoard);
        }

        [TestMethod]
        public void ApiMiddlewareTest()
        {
            var amw = new ApiMiddleware();
            Assert.IsNotNull(amw);

            var result = amw.Get(string.Concat("https://trello.com/b/", "hard_error", ".json")).Result;
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ApiMiddlewareRightTest()
        {
            var amw = new ApiMiddleware();
            Assert.IsNotNull(amw);

            var result2 = amw.Get(string.Concat("https://trello.com/b/", "wiOPDS9X", ".json")).Result;
            Assert.IsInstanceOfType(result2, typeof(Trello));
        }
    }
}
