using RoomGenerator.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace RoomGenerator.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IGeneratorRepository _generatorRepository => DependencyService.Get<IGeneratorRepository>();
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
