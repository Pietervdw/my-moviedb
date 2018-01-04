using System.Collections.Generic;
using System.Threading.Tasks;
using MyMovieDb.Models;

namespace MyMovieDb.Contracts.Repositories
{
	public interface IMovieRepository
	{
		Task<List<Genre>> GetGenres();
	}
}