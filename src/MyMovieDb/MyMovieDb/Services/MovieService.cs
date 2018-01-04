using System.Collections.Generic;
using System.Threading.Tasks;
using MyMovieDb.Contracts.Repositories;
using MyMovieDb.Contracts.Services;
using MyMovieDb.Models;

namespace MyMovieDb.Services
{
	public class MovieService : IMovieService
	{
		private readonly IMovieRepository _movieRepo;

		public MovieService(IMovieRepository movieRepo)
		{
			_movieRepo = movieRepo;
		}
		public async Task<List<Genre>> GetGenres()
		{
			return await _movieRepo.GetGenres();
		}
	}
}