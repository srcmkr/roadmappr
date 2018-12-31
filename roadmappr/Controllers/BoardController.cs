using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using roadmappr.Models;
using roadmappr.Models.ViewModels;

namespace roadmappr.Controllers
{
    public class BoardController : Controller
    {
        [Route("board/{url}")]
        public async Task<IActionResult> Index(string url)
        {
            var tdm = new TrelloDataModel(url);
            var board = await tdm.LoadAsync();

            if (!tdm.IsLoaded)
                return View("Error");

            var vm = new BoardViewModel
            {
                TrelloBoard = board,
                Source = tdm.Source
            };

            return View(vm);
        }
    }
}