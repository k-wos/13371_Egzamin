using _13371_Egzamin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13371_Egzamin.Controllers
{
    public class FurnitureBoardController : Controller
    {
        static IList<FurnitureBoard> boardList = new List<FurnitureBoard>();

        public IActionResult Index()
        {
            return View(boardList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FurnitureBoard board)
        {
            if (ModelState.IsValid)
            {
                board.Price = board.Price * board.Height * board.Width * board.Amount;
                boardList.Add(board);
                return RedirectToAction("Index");
            }
            else return View(board);
        }
    }
}
