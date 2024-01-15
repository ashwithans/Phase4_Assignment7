using Microsoft.AspNetCore.Mvc;
using WebAppAzure.Models;

namespace WebAppAzure.Controllers
{
    public class PlayersController : Controller
    {

        static List<Player> players = new List<Player>()
        {
            new Player() {PId=1, PName="Virat Kohli",PCountry="India", PType="Batsman"},
            new Player() {PId=2, PName="Rohit Sharma", PCountry="India", PType="Batsman"},
            new Player() {PId=3, PName="Ravindra Jadeja", PCountry="India", PType="All-rounder"},
            new Player() {PId=4, PName="Mohammed Shami", PCountry="India", PType="Bowler"},


        };
        public IActionResult Index()
        {
            return View(players);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }

        [HttpPost]
        public IActionResult Create(Player play)
        {
            if(ModelState.IsValid)
            {
                players.Add(play);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
