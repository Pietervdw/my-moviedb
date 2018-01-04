using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyMovieDb.Contracts.Repositories;
using MyMovieDb.Repositories;

namespace MyMovieDb.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
			
			DelegateCommand cmd = new DelegateCommand(ExecuteIt);
			cmd.Execute();

        }

	    async void ExecuteIt()
	    {
			IMovieRepository repo = new MovieRepository();
		    var result = await repo.GetGenres();
	    }
    }
}
