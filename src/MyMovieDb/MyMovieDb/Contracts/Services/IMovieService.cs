using System.Collections.Generic;
using System.Threading.Tasks;
using MyMovieDb.Models;

namespace MyMovieDb.Contracts.Services
{
	public interface IMovieService
	{
		Task<List<Genre>> GetGenres();
	}
}