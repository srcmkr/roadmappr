using Microsoft.VisualStudio.TestTools.UnitTesting;
using roadmappr.Controllers;
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
        public void BoardControllerTest()
        {
            var controller = new BoardController();
            var result = controller.Index("wiOPDS9X").Result;
            Assert.IsNotNull(result);
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
    }
}
