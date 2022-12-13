using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {
        // Simply returns our Setup.cshtml page, which is our default home page configured in RouteConfig.cs
        public ActionResult Setup()
        {
            return View();
        }

        // Constructor for Game view that takes in a parameter from Setup.cshtml for board dimensions
        public ActionResult Game(int? dimension)
        {
            // Check to see if a null type was sent over. If this is the case, default us to 3.
            if (!dimension.HasValue)
            {
                dimension = 3;
            }
            else if (dimension > 11)
            {
                dimension = 11;
            }

            // Sets the dimensions of the game board and returns it to the Game view to render. This value is grabbed from the Setup.cshtml page
            var board = new Board() { Dimension = (int)dimension };
            return View(board);
        }

    }
}