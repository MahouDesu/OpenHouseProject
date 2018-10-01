using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouseProject
{
    class AddClasses
    {
            Basement basement = new Basement() { FloorSpace = 18, RoomName = "Basement" };
            Bathroom bathroom = new Bathroom() { FloorSpace = 18, RoomName = "Bathroom" };
            FrontPorch frontPorch = new FrontPorch() { FloorSpace = 18, RoomName = "FrontPorch" };
            GuestRoom guestRoom = new GuestRoom() { FloorSpace = 10, RoomName = "GuestRoom" };
            LivingRoom livingRoom = new LivingRoom() { FloorSpace = 16, RoomName = "Basement" };
            MasterBedroom masterBedroom = new MasterBedroom() { FloorSpace = 14, RoomName = "Basement" };
            realtor realtor = new realtor("Nancy") { Employer = "Springwood Properties" };
    }
}
