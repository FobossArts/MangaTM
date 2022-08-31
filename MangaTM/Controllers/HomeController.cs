using MangaTM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace MangaTM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplicationContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            var idManga = db.Mangas.Where(e => e.MangaName == "Chainsaw-Man").Select(x => x.Id.ToString()).FirstOrDefault();
            var refer = db.Chapters.Where(e => e.MangaId == 1).Select(x => x.refer.ToString()).FirstOrDefault();
            using (var client = new WebClient())
            {
                client.DownloadFile(new Uri(refer), @"C:\python\p001_00.png");
            }
            var dbb = db.Mangas.Where(e => e.MangaName == "Chainsaw-Man").Select(x => x.MangaName.ToString());
            ViewBag.MangaName = dbb;
            return View(db);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}