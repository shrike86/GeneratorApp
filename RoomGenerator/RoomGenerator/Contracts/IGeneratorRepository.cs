using RoomGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RoomGenerator.Contracts
{
    public interface IGeneratorRepository
    {
        string GetRoomStocking();
        string GetRoomAtmosphere();
        string GetPlaces1();
        string GetPlaces2();
        string GetPlaces3();
        string GetOrnamentations1();
        string GetOrnamentations2();
    }
}
