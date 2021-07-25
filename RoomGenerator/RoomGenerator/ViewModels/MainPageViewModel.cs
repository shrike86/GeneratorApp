using RoomGenerator.Models;
using RoomGenerator.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RoomGenerator.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public GeneratedRoom Room { get; set; }

        #region Field Populated Booleans

        private bool isRoomStockingPopulated;
        private bool isRoomAtmospherePopulated;
        private bool isPlacePopulated;
        private bool isRoomOrnamentationPopulated;

        public bool IsPlacePopulated
        {
            get { return isPlacePopulated; }
            set
            {
                isPlacePopulated = value;
                OnPropertyChanged();
            }
        }

        public bool IsRoomStockingPopulated
        {
            get { return isRoomStockingPopulated; }
            set
            {
                isRoomStockingPopulated = value;
                OnPropertyChanged();
            }
        }

        public bool IsRoomAtmospherePopulated
        {
            get { return isRoomAtmospherePopulated; }
            set
            {
                isRoomAtmospherePopulated = value;
                OnPropertyChanged();
            }
        }

        public bool IsRoomOrnamentationPopulated
        {
            get { return isRoomOrnamentationPopulated; }
            set
            {
                isRoomOrnamentationPopulated = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Category Value Properties

        public string Place
        {
            get { return Room.Place == null ? string.Empty : string.Format("{0} {1} {2}", Room.Place.GeneratedValue, Room.Place.GeneratedValue2, Room.Place.GeneratedValue3); }
            set
            {
                IsPlacePopulated = true;
                OnPropertyChanged();
            }
        }

        public string BasicRoomStocking
        {
            get { return Room.BasicRoomStocking == null ? string.Empty : Room.BasicRoomStocking.GeneratedValue; }
            set
            {
                Room.BasicRoomStocking.GeneratedValue = value;
                IsRoomStockingPopulated = true;
                OnPropertyChanged();
            }
        }

        public string RoomAtmosphere
        {
            get { return Room.RoomAtmosphere == null ? string.Empty : Room.RoomAtmosphere.GeneratedValue; }
            set
            {
                Room.RoomAtmosphere.GeneratedValue = value;
                IsRoomAtmospherePopulated = true;
                OnPropertyChanged();
            }
        }

        public string RoomOrnamentation
        {
            get { return Room.RoomOrnamentations == null ? string.Empty : string.Format("{0} that are {1} and {2}", Room.RoomOrnamentations.GeneratedValue, Room.RoomOrnamentations.GeneratedValue2, Room.RoomOrnamentations.GeneratedValue3); }
            set
            {
                IsRoomOrnamentationPopulated = true;
                OnPropertyChanged();
            }
        }

        #endregion

        public MainPageViewModel()
        {
            Room = new GeneratedRoom();

            // Nothing is populated by default;
            isPlacePopulated = false;
            isRoomStockingPopulated = false;
            isRoomAtmospherePopulated = false;
            isRoomOrnamentationPopulated = false;

            MessagingCenter.Subscribe<GeneratorItemDetail, Generator>(this, "SaveBasicRoomStocking",
                (sender, value) =>
                {
                    Room.BasicRoomStocking = value;
                    BasicRoomStocking = value.GeneratedValue;
                });

            MessagingCenter.Subscribe<GeneratorItemDetail, Generator>(this, "SaveRoomAtmosphere",
             (sender, value) =>
             {
                 Room.RoomAtmosphere = value;
                 RoomAtmosphere = value.GeneratedValue;
             });

            MessagingCenter.Subscribe<GeneratorItemDetail_3, Generator>(this, "SavePlace",
              (sender, value) =>
              {
                  Room.Place = value;
                  Place = string.Format("{0} {1} {2}", value.GeneratedValue, value.GeneratedValue2, value.GeneratedValue3);
              });

            MessagingCenter.Subscribe<GeneratorItemDetail_3, Generator>(this, "SaveRoomOrnamentation",
               (sender, value) =>
               {
                   Room.RoomOrnamentations = value;
                   RoomOrnamentation = string.Format("{0} that are {1} and {2}", value.GeneratedValue, value.GeneratedValue2, value.GeneratedValue3);
               });
        }
    }
}
