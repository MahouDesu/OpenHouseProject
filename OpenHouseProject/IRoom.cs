using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouseProject
{
    public interface IRoom
    {
        string RoomName { get; set; }
        int FloorSpace { get; set; }
    }
}
