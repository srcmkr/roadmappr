using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LiteDB;
using roadmappr.Data;

namespace roadmappr.Models
{
    public class TrelloDataModel
    {
        private readonly string _trelloUrl;
        public bool IsLoaded { get; set; }
        public string Source { get; set; }

        public TrelloDataModel(string url)
        {
            const string pattern = @"([a-zA-Z0-9]{1,12})";
            if (Regex.IsMatch(url, pattern))
            {
                _trelloUrl = url;
            }

            IsLoaded = false;
        }

        public async Task<Trello> DownloadAsync()
        {
            var apiMiddleware = new ApiMiddleware();
            var apiResponse = await apiMiddleware.Get(string.Concat("https://trello.com/b/", _trelloUrl, ".json"));
            Source = "online";
            apiResponse.LastDbUpdate = DateTime.Now;
            AddOrUpdate(apiResponse);

            return apiResponse;
        }

        public Trello LoadFromDatabase()
        {
            using (var db = new LiteDatabase(new ConnectionString
            {
                Filename = "trello.db"
            }))
            {
                var collection = db.GetCollection<Trello>("roadmappr");
                var trelloBoard = collection.FindById(_trelloUrl);
                if (trelloBoard != null && trelloBoard.LastDbUpdate >= DateTime.Now.AddMinutes(-60))
                {
                    IsLoaded = true;
                    Source = "cache";
                    return trelloBoard;
                }
            }

            return null;
        }

        public bool AddOrUpdate(Trello trelloBoard)
        {
            try
            {
                using (var db = new LiteDatabase(new ConnectionString
                {
                    Filename = "trello.db"
                }))
                {
                    var collection = db.GetCollection<Trello>("roadmappr");
                    if (collection.FindById(_trelloUrl) != null)
                    {
                        collection.Update(_trelloUrl, trelloBoard);
                        return true;
                    }

                    collection.Insert(_trelloUrl, trelloBoard);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<Trello> LoadAsync()
        {
            var trelloBoard = LoadFromDatabase() ?? await DownloadAsync();

            if (trelloBoard != null)
            {
                foreach (var card in trelloBoard.Cards)
                {
                    card.Desc = card.DescLimited();
                }
                IsLoaded = true;
            }

            return trelloBoard;
        }
    }
}
