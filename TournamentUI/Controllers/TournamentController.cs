using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace TournamentUI.Controllers
{
    [Route("tournament")]
    public class TournamentController : Controller
    {

        [HttpGet("viewer")]
        public IActionResult TournamentViewer()
        {
            return View();
        }

        [HttpGet("create")]
        public IActionResult CreateTournament()
        {
            return View();
        }


        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
