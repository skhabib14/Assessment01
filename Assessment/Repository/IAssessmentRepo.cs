using Assessment.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Repository
{
    public interface IAssessmentRepo
    {
        Task<IQueryable<moviesTable>> getMovies(string title, string rating, string category);
    }
}
