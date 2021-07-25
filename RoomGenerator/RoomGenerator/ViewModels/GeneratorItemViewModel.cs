using RoomGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomGenerator.ViewModels
{
    public class GeneratorItemViewModel : BaseViewModel
    {
        public Generator Generator{ get; set; }

        public string GeneratorDescription
        {
            get { return Generator.Description; }
            set 
            { 
                Generator.Description = value;
                OnPropertyChanged();
            }
        }

        public string GeneratedValue
        {
            get { return Generator.GeneratedValue; }
            set
            {
                Generator.GeneratedValue = value;
                OnPropertyChanged();
            }
        }

        public string GeneratedValue2
        {
            get { return Generator.GeneratedValue2; }
            set
            {
                Generator.GeneratedValue2 = value;
                OnPropertyChanged();
            }
        }

        public string GeneratedValue3
        {
            get { return Generator.GeneratedValue3; }
            set
            {
                Generator.GeneratedValue3 = value;
                OnPropertyChanged();
            }
        }

        public GeneratorType Type
        {
            get { return Generator.Type; }
            set
            {
                Generator.Type = value;
                OnPropertyChanged();
            }
        }

        public GeneratorItemViewModel(Generator generator = null)
        {
            this.Generator = generator;
        }
    }
}
