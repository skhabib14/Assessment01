using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment.Models;
using Assessment.Repository;
using System.Threading.Tasks;

namespace Assessment.Controllers
{
    public class HomeController : Controller
    {
        IAssessmentRepo _assessmentRepo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAssessmentRepo assessmentRepo)
        {
            _logger = logger;
            _assessmentRepo = assessmentRepo;
        }

        public async Task<IActionResult> Index(string title, string rating, string category)
        {
            try
            {
                var movieList = await _assessmentRepo.getMovies(title,rating,category);
                ViewBag.ListofMovie = movieList;
                return View(movieList);
            }
            catch (Exception ex)
            {
                return View();
            }
            return View();
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
