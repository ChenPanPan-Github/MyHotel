using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelDAL;
using MyHotelModel.DataBaseModel;

namespace MyHotelBLL
{
    public static class RoomStateManager
    {
        /// <summary>
        /// 获取房间状态
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static List<RoomState> GetAllRoomState()
        {
            return  RoomStateService.GetAllRoomState();
        }
    }
}
