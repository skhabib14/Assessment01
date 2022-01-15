using Assessment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Repository
{
    public class AssessmentRepo : IAssessmentRepo
    {
        private readonly AssessmentDBContext _db;

        public AssessmentRepo(AssessmentDBContext db)
        {
            _db = db;
        }

        async Task<IQueryable<moviesTable>> IAssessmentRepo.getMovies(string title, string rating, string category)
        {
            var movieList = _db.Movies.AsQueryable();
            if (!String.IsNullOrEmpty(title))
            {
                movieList = movieList.Where(t => t.Title.Contains(title));
            }
            if (!String.IsNullOrEmpty(rating))
            {
                movieList = movieList.Where(r => r.Rating.Contains(rating));
            }
            if (!String.IsNullOrEmpty(category))
            {
                movieList = movieList.Where(c => c.Category.Contains(category));
            }
            return movieList;
        }
    }
}
