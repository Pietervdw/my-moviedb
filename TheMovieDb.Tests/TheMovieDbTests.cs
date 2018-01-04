using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbLib.Client;

namespace TheMovieDb.Tests
{
	/// <summary>
	/// A few simple test to try out The Movie DB Api
	/// </summary>
	[TestClass]
	public class TheMovieDbTests
	{
		private string apiKey = "";
		[TestMethod]
		public async Task GetGenres()
		{
			TMDbClient client = new TMDbClient(apiKey);
			var genres = await client.GetMovieGenresAsync();
		}

		[TestMethod]
		public async Task GetMoviesForGenre()
		{
			TMDbClient client = new TMDbClient(apiKey);
			var movies = await client.GetGenreMoviesAsync(28);//35
			
		}
	}
}
