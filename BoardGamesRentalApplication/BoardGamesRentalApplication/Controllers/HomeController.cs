﻿using BoardGamesRentalApplication.BLL.IService;
using BoardGamesRentalApplication.Models;
using System.Linq;
using System.Web.Mvc;

namespace BoardGamesRentalApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBoardGamesService boardGamesService;

        public HomeController(IBoardGamesService boardGamesService)
        {
            this.boardGamesService = boardGamesService;
        }

        public ActionResult Index(HomePageData homePageData)
        {
            homePageData.RecommendedBoardGames = boardGamesService
                                                .GetFourRecommendedBoardGames()
                                                .Select(bg => new BoardGame()
                                                {
                                                    BoardGameId = bg.BoardGameId,
                                                    Name = bg.Name,
                                                    Image = bg.Image,
                                                    PlayerCount = bg.PlayerCount,
                                                    MinimumAge = bg.MinimumAge
                                                });
            return View(homePageData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }
    }
}