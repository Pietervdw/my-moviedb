using System.Collections.Generic;
using AutoMapper;
using AutoMapper.Configuration;
using MyMovieDb.ViewModels;
using MyMovieDb.Views;
using DryIoc;
using Prism.DryIoc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyMovieDb
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
	        InitAutoMapper();

			await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
        }

	    private void InitAutoMapper()
	    {
			MapperConfigurationExpression cfg = new MapperConfigurationExpression();
		    cfg.CreateMap<TMDbLib.Objects.General.Genre, Models.Genre>();

			Mapper.Initialize(cfg);
	    }
    }
}
