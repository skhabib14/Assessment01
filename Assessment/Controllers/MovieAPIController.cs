using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieAPIController : ControllerBase
    {
        private readonly AssessmentDBContext _db;

        public MovieAPIController(AssessmentDBContext db)
        {
            _db = db;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var movieList = _db.Movies.Where(p => p.Title.Contains(term)).Select(p => new { p.Title, p.Rating, p.Category }).ToList();
                return Ok(movieList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("MovieList")]
        public async Task<IActionResult> MovieList(string title, string rating, string category)
        {
            try
            {
                return Ok
                   (
                       await _db.Movies
                       .Where(
                           m => m.Title.ToLower().Contains(title ?? string.Empty)
                        && (string.IsNullOrEmpty(rating) ? true : rating.Contains(m.Rating))
                        && (string.IsNullOrEmpty(category) ? true : category.Contains(m.Category))
                       ).ToListAsync()
                   );
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
