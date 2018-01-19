using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MyMovieDb.Contracts.Repositories;
using MyMovieDb.Extensions;
using MyMovieDb.Models;

namespace MyMovieDb.ViewModels
{
    public class GenrePageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IMovieRepository _movieRepo;

        public GenrePageViewModel(INavigationService navigationService, IMovieRepository movieRepo)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _movieRepo = movieRepo;
            Title = "Genres";
            LoadGenresCommand.Execute();
        }

        private ObservableCollection<Genre> _genres;
        public ObservableCollection<Genre> Genres
        {
            get { return _genres; }
            set { SetProperty(ref _genres, value); }
        }

        private DelegateCommand _loadGenresCommand;
        public DelegateCommand LoadGenresCommand => _loadGenresCommand ?? (_loadGenresCommand = new DelegateCommand(LoadGenres));

        async void LoadGenres()
        {
            IsBusy = true;
            var genreData = await _movieRepo.GetGenres();
            Genres = genreData.ToObservableCollection();
            IsBusy = false;
        }


    }
}
