using System.Collections.Generic;
using System.Threading.Tasks;
using MyMovieDb.Contracts.Repositories;
using MyMovieDb.Models;
using TMDbLib.Client;

namespace MyMovieDb.Repositories
{
	public class MovieRepository : IMovieRepository
	{
		TMDbClient _client = new TMDbClient("---YOUR-API-KEY---");

		public Task<List<Genre>> GetGenres()
		{
			throw new System.NotImplementedException();
		}
	}
}