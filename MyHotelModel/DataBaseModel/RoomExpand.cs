using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelModel.DataBaseModel
{
    public class RoomExpand : Room
    {
        //房间类型名称
        public string roomtype_name { get; set; }
        //房间状态名称
        public string roomstate_name { get; set; }
    }
}
