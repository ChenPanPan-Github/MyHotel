using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHotelModel.DataBaseModel;

namespace MyHotelDAL
{
    public static class RoomStateService
    {
        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        public static List<RoomState> GetAllRoomState()
        {
            return SqlHelper.db.Queryable<RoomState>().ToList();
        }
    }
}
