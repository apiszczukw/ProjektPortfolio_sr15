using Microsoft.AspNetCore.Mvc;
using ProjektPortfolio_czw15.DAL;
using ProjektPortfolio_czw15.Models;
using System.Diagnostics;

namespace ProjektPortfolio_czw15.Controllers
{
	public class HomeController : Controller
	{
		ProjektyContext db;

		public HomeController(ProjektyContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Projekty()
		{
			ViewBag.Projekty = db.Projekty.ToList();

			return View();
		}

		public IActionResult Sites(string name)
		{
			return View(name);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}