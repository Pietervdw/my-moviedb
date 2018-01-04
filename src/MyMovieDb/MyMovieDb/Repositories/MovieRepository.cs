using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MyMovieDb.Contracts.Repositories;
using MyMovieDb.Models;
using TMDbLib.Client;

namespace MyMovieDb.Repositories
{
	public class MovieRepository : IMovieRepository
	{
		TMDbClient _client = new TMDbClient("---YOUR-API-KEY---");

		public async Task<List<Genre>> GetGenres()
		{
			var genres = await _client.GetMovieGenresAsync();
			var result = Mapper.Map<List<TMDbLib.Objects.General.Genre>, List<Models.Genre>>(genres);
			return result;
		}
	}
}