using RoomGenerator.Contracts;
using RoomGenerator.Repository;
using RoomGenerator.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoomGenerator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneratorItemDetail : ContentPage
    {
        public IGeneratorRepository _generatorRepository = DependencyService.Get<IGeneratorRepository>() ?? new GeneratorRepository();
        
        private readonly GeneratorItemViewModel _viewModel;
        

        public GeneratorItemDetail(GeneratorItemViewModel generatorItemViewModel)
        {
            InitializeComponent();

            _viewModel = generatorItemViewModel;
            BindingContext = _viewModel;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            switch (_viewModel.Type)
            {
                case Models.GeneratorType.BasicRoomStocking:
                    MessagingCenter.Send(this, "SaveBasicRoomStocking", _viewModel.Generator);  
                    break;
                case Models.GeneratorType.RoomAtmosphere:
                    MessagingCenter.Send(this, "SaveRoomAtmosphere", _viewModel.Generator);
                    break;
                case Models.GeneratorType.RoomOrnamentation:
                    break;
                case Models.GeneratorType.NeutralRoomInhabitant:
                    break;
                case Models.GeneratorType.DangerousRoomInhabitant:
                    break;
                case Models.GeneratorType.Device:
                    break;
                case Models.GeneratorType.Trap:
                    break;
                case Models.GeneratorType.Treasure:
                    break;
                default:
                    break;
            }
            Navigation.PopModalAsync();
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Generate_Clicked(object sender, EventArgs e)
        {
            switch (_viewModel.Type)
            {
                case Models.GeneratorType.BasicRoomStocking:
                    _viewModel.GeneratedValue = _generatorRepository.GetRoomStocking();
                    break;
                case Models.GeneratorType.RoomAtmosphere:
                    _viewModel.GeneratedValue = _generatorRepository.GetRoomAtmosphere();
                    break;
                case Models.GeneratorType.RoomOrnamentation:
                    break;
                case Models.GeneratorType.NeutralRoomInhabitant:
                    break;
                case Models.GeneratorType.DangerousRoomInhabitant:
                    break;
                case Models.GeneratorType.Device:
                    break;
                case Models.GeneratorType.Trap:
                    break;
                case Models.GeneratorType.Treasure:
                    break;
                default:
                    break;
            }
        }
    }
}