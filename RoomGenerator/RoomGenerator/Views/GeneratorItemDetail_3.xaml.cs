
using RoomGenerator.Contracts;
using RoomGenerator.Repository;
using RoomGenerator.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoomGenerator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneratorItemDetail_3 : ContentPage
    {
        public IGeneratorRepository _generatorRepository = DependencyService.Get<IGeneratorRepository>() ?? new GeneratorRepository();

        private readonly GeneratorItemViewModel _viewModel;

        public GeneratorItemDetail_3(GeneratorItemViewModel generatorItemViewModel)
        {
            InitializeComponent();
            _viewModel = generatorItemViewModel;
            BindingContext = _viewModel;
        }

        private void Generate_Clicked(object sender, EventArgs e)
        {
            switch (_viewModel.Type)
            {
                case Models.GeneratorType.Place:
                    _viewModel.GeneratedValue = _generatorRepository.GetPlaces1();
                    break;
                case Models.GeneratorType.RoomOrnamentation:
                    _viewModel.GeneratedValue = _generatorRepository.GetOrnamentations1();
                    break;
                default:
                    break;
            }
        }

        private void Generate2_Clicked(object sender, EventArgs e)
        {
            switch (_viewModel.Type)
            {
                case Models.GeneratorType.Place:
                    _viewModel.GeneratedValue2 = _generatorRepository.GetPlaces2();
                    break;
                case Models.GeneratorType.RoomOrnamentation:
                    _viewModel.GeneratedValue2 = _generatorRepository.GetOrnamentations2();
                    break;
                default:
                    break;
            }
        }

        private void Generate3_Clicked(object sender, EventArgs e)
        {
            switch (_viewModel.Type)
            {
                case Models.GeneratorType.Place:
                    _viewModel.GeneratedValue3 = _generatorRepository.GetPlaces3();
                    break;
                case Models.GeneratorType.RoomOrnamentation:
                    _viewModel.GeneratedValue3 = _generatorRepository.GetOrnamentations2();
                    break;
                default:
                    break;
            }
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            switch (_viewModel.Type)
            {
                case Models.GeneratorType.Place:
                    MessagingCenter.Send(this, "SavePlace", _viewModel.Generator);
                    break;
                case Models.GeneratorType.RoomOrnamentation:
                    MessagingCenter.Send(this, "SaveRoomOrnamentation", _viewModel.Generator);
                    break;
            }

            Navigation.PopModalAsync();
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}