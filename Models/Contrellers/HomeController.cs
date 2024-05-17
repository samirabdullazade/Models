using Models.Models;


using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.Home;

namespace Models.Contrellers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Feature> features = new List<Feature>
            {
                new Feature {Id = 1,Title="free storage1",Path="featured-01.png"},
                new Feature {Id = 2,Title="user more1",Path="featured-02.png"},
                new Feature {Id = 3,Title="reply ready1",Path="featured-03.png"},
                new Feature {Id = 4,Title="easy layout1",Path="featured-04.png"},
            };
                List<Game> games = new List<Game>
            {
                new Game{Id = 1 , Name = "Assasin Creed" , Category = "Oper Wordld" , ImagePath = "trending-01.jpg",Price = 20},
                new Game{Id = 2 , Name = "Counter-Strike 2" , Category = "Pvp" , ImagePath = "trending-02.jpg",Price = 100},
                new Game{Id = 3 , Name = "Valorant" , Category = "Pvp" , ImagePath = "trending-03.jpg",Price = 0},
                new Game{Id = 4 , Name = "Pubg" , Category = "Mobile" , ImagePath = "trending-04.jpg",Price = 50},
                new Game{Id = 5 , Name = "Pubg" , Category = "Mobile" , ImagePath = "top-game-05.jpg",Price = 50},
                new Game{Id = 6 , Name = "Pubg" , Category = "Mobile" , ImagePath = "top-game-06.jpg",Price = 50},
            };


                HomeIndexVM homeIndexVM = new HomeIndexVM()
                {
                    Features = features,
                    Games = games,
                };

                return View(homeIndexVM);
        }
    }
}
