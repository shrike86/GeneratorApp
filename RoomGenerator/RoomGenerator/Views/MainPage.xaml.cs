using RoomGenerator.Models;
using RoomGenerator.ViewModels;
using RoomGenerator.Views;
using System;
using Xamarin.Forms;

namespace RoomGenerator
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel _viewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainPageViewModel();
            BindingContext = _viewModel;
        }

        private void Place_Clicked(object sender, EventArgs e)
        {
            GeneratorItemViewModel viewModel = new GeneratorItemViewModel
            {
                Generator = new RoomStocking
                {
                    Description = "Place",
                    Type = GeneratorType.Place
                }
            };

            if (_viewModel.Room.Place != null)
            {
                viewModel.Generator.GeneratedValue = _viewModel.Room.Place.GeneratedValue;
                viewModel.Generator.GeneratedValue2 = _viewModel.Room.Place.GeneratedValue2;
                viewModel.Generator.GeneratedValue3 = _viewModel.Room.Place.GeneratedValue3;
            }

            Navigation.PushModalAsync(new NavigationPage(new GeneratorItemDetail_3(viewModel)));
        }

        private void RoomStocking_Clicked(object sender, EventArgs e)
        {
            GeneratorItemViewModel viewModel = new GeneratorItemViewModel
            {
                Generator = new RoomStocking 
                {
                    Description = "Basic Room Stocking",
                    Type = GeneratorType.BasicRoomStocking
                }
            };

            if (_viewModel.BasicRoomStocking != null)
            {
                viewModel.Generator.GeneratedValue = _viewModel.BasicRoomStocking;
            }

            Navigation.PushModalAsync(new NavigationPage(new GeneratorItemDetail(viewModel)));
        }

        private void RoomAtmosphere_Clicked(object sender, EventArgs e)
        {
            GeneratorItemViewModel viewModel = new GeneratorItemViewModel
            {
                Generator = new RoomStocking
                {
                    Description = "Room Atmosphere",
                    Type = GeneratorType.RoomAtmosphere
                }
            };

            if (_viewModel.RoomAtmosphere != null)
            {
                viewModel.Generator.GeneratedValue = _viewModel.RoomAtmosphere;
            }

            Navigation.PushModalAsync(new NavigationPage(new GeneratorItemDetail(viewModel)));
        }

        private void RoomOrnamentations_Clicked(object sender, EventArgs e)
        {
            GeneratorItemViewModel viewModel = new GeneratorItemViewModel
            {
                Generator = new RoomStocking
                {
                    Description = "Prominent Room Ornamentations",
                    Type = GeneratorType.RoomOrnamentation
                }
            };

            if (_viewModel.Room.RoomOrnamentations != null)
            {
                viewModel.Generator.GeneratedValue = _viewModel.Room.RoomOrnamentations.GeneratedValue;
                viewModel.Generator.GeneratedValue2 = _viewModel.Room.RoomOrnamentations.GeneratedValue2;
                viewModel.Generator.GeneratedValue3 = _viewModel.Room.RoomOrnamentations.GeneratedValue3;
            }

            Navigation.PushModalAsync(new NavigationPage(new GeneratorItemDetail_3(viewModel)));
        }
    }
}
